using MVVM_Learning.Model;
using System.Collections.ObjectModel;

namespace MVVM_Learning.ViewModel
{
    public class StudentViewModel
    {
        public ObservableCollection<Student> Students { get; set; }

        public void LoadStudents()
        {
            ObservableCollection<Student> students = new ObservableCollection<Student>();
            students.Add(new Student { FirstName = "Mark", LastName = "Allain" });
            students.Add(new Student { FirstName = "Allen", LastName = "Brown" });
            students.Add(new Student { FirstName = "Linda", LastName = "Hamerski" });
            Students = students;
        }

    }
}