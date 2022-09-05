using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Mediator mediator = new Mediator();
          
            Teacher helin = new Teacher (mediator);
            helin.Name = "helin";
            mediator.Teacher = helin;
            Student emir = new Student(mediator);
            emir.Name = "Emir";
           
           
            Student feyza = new Student(mediator);
            feyza.Name = "feyza";
            mediator.Students = new List<Student> { emir, feyza };

            helin.SenNewImageUrl("slide1.jpg");

            Console.ReadLine();


        }
    }
    abstract class CourseMember
    {
        protected Mediator Mediator;
      protected CourseMember(Mediator mediator)
        {
            Mediator=mediator;
        }
    }
    class Teacher : CourseMember
    {
        public string Name { get;  set; }

        public Teacher(Mediator mediator) : base(mediator)
        {

        }
       
        public void RecieveQuestion(string question, Student student)
        {
            Console.WriteLine("Teacher recieved a question from {0},{1}", student.Name, question);
        }
        public void SenNewImageUrl(string url)
        {
            Console.WriteLine("Teacher changed slide: {0}", url);
            Mediator.UpDateImage(url);
        }
        public void AnswerQuestion(string answer,Student student)
        {
            Console.WriteLine("Teacher answered question {0},{1}", student.Name,answer);
        }
    }
    class Student : CourseMember
    {
        public Student(Mediator mediator): base(mediator)
        {

        }
        public string Name { get;  set; }

        public  void RecieveImage(string url)
        {
            Console.WriteLine("Student received image: {0}", url);
            
        }

        public void RecieveAnswer(string answer)
        {
            Console.WriteLine("Student received answer {0}", answer);
        }
    }
    class Mediator
    {
        public Teacher  Teacher { get; set; }
        public List<Student> Students { get; set; }

        public void UpDateImage(string url)
        {
            foreach (var student in Students)
            {
                student.RecieveImage(url);

            }
        }
        public void SendQuestion(string question,Student student)
        {
            Teacher.RecieveQuestion(question,student);
        }
        public void SendAnswer(string answer,Student student)
        {
            student.RecieveAnswer(answer);
        }
    }
}
