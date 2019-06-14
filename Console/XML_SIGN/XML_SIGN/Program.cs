using System;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Xml;
using System.IO;

public class SignXML
{

    public static void Main(String[] args)
    {
        try
        {
            // Create a new CspParameters object to specify
            // a key container.
            CspParameters cspParams = new CspParameters();
            cspParams.KeyContainerName = "XML_DSIG_RSA_KEY";

            // Create a new RSA signing key and save it in the container. 
            RSACryptoServiceProvider rsaKey = new RSACryptoServiceProvider(cspParams);

            // Create a new XML document.
            XmlDocument xmlDoc = new XmlDocument();

            // Load an XML file into the XmlDocument object.
            xmlDoc.PreserveWhitespace = true;
            xmlDoc.Load("encrypted.xml");

            // Sign the XML document. 
            SignXml(xmlDoc, rsaKey);

            Console.WriteLine("XML file signed.");

            // Save the document.
            xmlDoc.Save("signed.xml");

            File.WriteAllText(@"F:\Programming Projects\Visual Studio\Visual C#\XML_SIGN\XML_SIGN\bin\Debug\key.xml", rsaKey.ToXmlString(true));

            Console.ReadKey();



        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }


    // Sign an XML file. 
    // This document cannot be verified unless the verifying 
    // code has the key with which it was signed.
    public static void SignXml(XmlDocument xmlDoc, RSA Key)
    {
        // Check arguments.
        if (xmlDoc == null)
            throw new ArgumentException("xmlDoc");
        if (Key == null)
            throw new ArgumentException("Key");

        // Create a SignedXml object.
        SignedXml signedXml = new SignedXml(xmlDoc);

        // Add the key to the SignedXml document.
        signedXml.SigningKey = Key;
        //Console.Write(" \nThe Signing Key is : "+Key+"\n");
        

        // Create a reference to be signed.
        Reference reference = new Reference();
        reference.Uri = "";

        // Add an enveloped transformation to the reference.
        XmlDsigEnvelopedSignatureTransform env = new XmlDsigEnvelopedSignatureTransform();
        reference.AddTransform(env);

        // Add the reference to the SignedXml object.
        signedXml.AddReference(reference);

        // Compute the signature.
        signedXml.ComputeSignature();

        // Get the XML representation of the signature and save
        // it to an XmlElement object.
        XmlElement xmlDigitalSignature = signedXml.GetXml();

        // Append the element to the XML document.
        xmlDoc.DocumentElement.AppendChild(xmlDoc.ImportNode(xmlDigitalSignature, true));

    }
}