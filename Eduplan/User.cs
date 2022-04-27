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
                        return true; 
                    }
                }
                return false;
            }
        }
        public static void WriteData(string email, string password)
        {
            using (StreamReader r = new StreamReader(Directory.GetCurrentDirectory() + @"\Database.json"))
            {
                string json = r.ReadToEnd();
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
        }
    }
}
