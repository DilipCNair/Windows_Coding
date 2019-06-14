using System.Collections.ObjectModel;
using Command_Delegating_Example.Model;
using Command_Delegating_Example.Commands;

namespace Command_Delegating_Example.ViewModel
{
    public class StudentViewModel
    {

        private Student _selectedStudent;


        public ObservableCollection<Student> Students { get; set; }

        public Student SelectedStudent
        {
            get
            {
                return _selectedStudent;
            }

            set
            {
                _selectedStudent = value;
                DeleteCommand.RaiseCanExecuteChanged();
            }
        }

        public MyICommand DeleteCommand { get; set; }


        public StudentViewModel()
        {
            LoadStudents();
            DeleteCommand = new MyICommand(OnDelete, CanDelete);
        }    

        public void LoadStudents()
        {
            ObservableCollection<Student> students = new ObservableCollection<Student>();

            students.Add(new Student { FirstName = "Mark", LastName = "Allain" });
            students.Add(new Student { FirstName = "Allen", LastName = "Brown" });
            students.Add(new Student { FirstName = "Linda", LastName = "Hamerski" });

            Students = students;
        }
     
        private void OnDelete()
        {
            Students.Remove(SelectedStudent);
        }

        private bool CanDelete()
        {
            return SelectedStudent != null;
        }
    }
}
