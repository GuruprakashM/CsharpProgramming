using System;

namespace AdmissionProcess
{
    public enum Gender {Default, Male,Female,Transgender}
    public class StudentDetails
    {
        private static int s_studentID=3000;
        public  string StudentID{ get; set; }

        public string StudentName { get; set; }

        public string FatherName { get; set; }
        public DateTime DoB { get; set; }
        
        public Gender Gender{get; set;}
        
        public int PhysiceMark { get; set; }

        public int ChemistryMark{get; set;}
        public int MathsMark { get; set; }
        
        
        public StudentDetails(string studentName,String fatherName, DateTime dOB,Gender gender,int physiceMark, int chemistryMark,int mathsMark) 
        {
            s_studentID++;
            StudentID="SF"+s_studentID;
            StudentName=studentName;
            FatherName=fatherName;
            DoB=dOB;
            Gender=gender;
            PhysiceMark=physiceMark;
            ChemistryMark=chemistryMark;
            MathsMark=mathsMark;

        }
        
        public void ShowDetails()
        {
            Console.WriteLine($"student_ID: {StudentID} \nStudentName :{StudentName} \nFatherName :{FatherName} \nDOB :{DoB} \nGender{Gender}  \nPhysicMark{PhysiceMark} \nChemistryMark{ChemistryMark} \nMAthsMark{MathsMark}");
             
        }
        public bool CheckEgliblity(double cutoff)
        {
            double average=(PhysiceMark+ChemistryMark+MathsMark)/6.0;
            if(average>=cutoff)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        
        
        
        
         
    }
}