using DocumentFormat.OpenXml.Drawing.Charts;
using Grpc.Core;
using Nancy.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Eduplan
{
    class User
    {
        public static List<int> ReceiveGrades(string email)
        {
            List<int> Grades = new List<int>();
            using (StreamReader r = new StreamReader(Directory.GetCurrentDirectory() + @"\Database.json"))
            {
                string json = r.ReadToEnd();
                dynamic Data = JsonConvert.DeserializeObject(json);

                foreach (var value in Data)
                {
                    if (value.Email == email)
                    {
                        Grades.Add(Convert.ToInt32(value.Test1Grade));
                        Grades.Add(Convert.ToInt32(value.Test2Grade));
                        Grades.Add(Convert.ToInt32(value.Test3Grade));
                        Grades.Add(Convert.ToInt32(value.TestFinalGrade));

                        return Grades;
                    }
                }
                return Grades;
            }
        }

        public static bool ReceiveDataForLogin(string email, string password)
        {
            using (StreamReader r = new StreamReader(Directory.GetCurrentDirectory() + @"\Database.json"))
            {
                string json = r.ReadToEnd();
                dynamic Data = JsonConvert.DeserializeObject(json);
                
                foreach (var value in Data)
                {
                    if (value.Email == email && value.Password == password)
                    {
                        Functions.loginAs = email;
                        return true; 
                    }
                }
                return false;
            }
        }
        public static void WriteData(string email, string password)
        {
            string json = File.ReadAllText(Directory.GetCurrentDirectory() + @"\Database.json");

            var employeeList = JsonConvert.DeserializeObject<List<Person>>(json) ?? new List<Person>();

            employeeList.Add(new Person()
            {
                Email = email,
                Password = password,
                Test1Grade = 0,
                Test2Grade = 0,
                Test3Grade = 0,
                TestFinalGrade = 0
            });

            json = JsonConvert.SerializeObject(employeeList, Newtonsoft.Json.Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            File.WriteAllText(Directory.GetCurrentDirectory() + @"\Database.json", json);
        }
        public static void WriteSpecificGrade(string email, int grade, string test)
        {
            string json = File.ReadAllText(Directory.GetCurrentDirectory() + @"\Database.json");

            dynamic Data = JsonConvert.DeserializeObject(json);
            foreach (var value in Data)
            {
                if (value.Email.ToString() == email)
                {
                    if ("Test1Grade" == test)
                    {
                        value.Test1Grade = grade;
                    }
                    else if ("Test2Grade" == test)
                    {
                        value.Test2Grade = grade;
                    }
                    else if ("Test3Grade" == test)
                    {
                        value.Test3Grade = grade;
                    }
                    else if ("TestFinalGrade" == test)
                    {
                        value.TestFinalGrade = grade;
                    }
                }
            }
            string output = JsonConvert.SerializeObject(Data, Newtonsoft.Json.Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            File.WriteAllText(Directory.GetCurrentDirectory() + @"\Database.json", output);
        }
    }
}
