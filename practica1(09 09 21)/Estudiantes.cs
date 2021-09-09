using System;
using System.Collections.Generic;
using System.Text;

namespace practica1_09_09_21_
{
    class Estudiantes
    {
         
    

    public int idEstudiantes { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
    

    public static List<Estudiantes> GetEstudiantes()
        {
            List<Estudiantes> students = new List<Estudiantes>
            {
                new Estudiantes{ idEstudiantes= 1001, firstName= "Oliver", lastName="Rosales", age=18 , gender="Masculino" },
                new Estudiantes{ idEstudiantes= 1002, firstName= "Julissa", lastName="Claros", age=18 , gender="Femenino" },
                new Estudiantes{ idEstudiantes= 1003, firstName= "Diego", lastName="Miranda", age=19 , gender="Masculino"},
                new Estudiantes{ idEstudiantes= 1004, firstName= "Guillermo", lastName="Cano", age=26 , gender="Masculino" },
                new Estudiantes{ idEstudiantes= 1005, firstName= "Ismael",lastName="Luna", age=19 , gender="Masculino" },
                new Estudiantes{ idEstudiantes= 1006, firstName= "Naser", lastName="Rivera", age=18 , gender="Masculino" },
                new Estudiantes{ idEstudiantes= 1007, firstName= "Ulises", lastName="Landaverde", age=21 , gender="Masculino" },
            };
            return students;
        }


    }
}


    

