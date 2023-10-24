using courses.wwwapi.Models;

namespace courses.wwwapi.Data
{
    public static class Seeder
    {
        private static List<Course> _courses = new List<Course>() { 
            new Course() { id = 1, name = "Discrete Mathematics", ects = 7, description = "Compulsory courses", semester = 1, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 2, name = "Introduction to Computer Science and Telecommunications", ects = 2, description = "General Education", semester = 1, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 3, name = "Introduction to Programming", ects = 7, description = "Compulsory courses", semester = 1, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 4, name = "Linear Algebra", ects = 6, description = "Compulsory courses", semester = 1, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 5, name = "Logic Design", ects = 6, description = "Compulsory courses", semester = 1, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 6, name = "Logic Design Lab", ects = 2, description = "Optional Laboratory courses", semester = 1, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 7, name = "Analysis Ι", ects = 8, description = "Compulsory courses", semester = 2, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 8, name = "Applied Mathematics", ects = 6, description = "Elective Specialization courses", semester = 2, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 9, name = "Computer Architecture I", ects = 7, description = "Compulsory courses", semester = 2, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 10, name = "Data Structures", ects = 7, description = "Compulsory courses", semester = 2, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 11, name = "Electromagnetism - Optics and Modern Physics", ects = 8, description = "Compulsory courses", semester = 2, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 12, name = "Analysis II", ects = 8, description = "Compulsory courses", semester = 3, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 13, name = "Circuits and Systems Laboratory", ects = 2, description = "Optional Laboratory courses", semester = 3, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 14, name = "Object-Oriented Programming", ects = 8, description = "Compulsory courses", semester = 3, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 15, name = "Propability and Statistics", ects = 6, description = "Compulsory courses", semester = 3, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 16, name = "Signals and Systems", ects = 6, description = "Compulsory courses", semester = 3, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 17, name = "Algorithms and Complexity", ects = 8, description = "Compulsory courses", semester = 4, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 18, name = "Communication Networks I", ects = 6, description = "Compulsory courses", semester = 4, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 19, name = "Communication Systems", ects = 7, description = "Compulsory courses", semester = 4, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 20, name = "Communications Network I Lab", ects = 2, description = "Optional Laboratory courses", semester = 4, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 21, name = "Design and Use of Database Systems", ects = 7, description = "Compulsory courses", semester = 4, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 22, name = "Artificial Intelligence", ects = 6, description = "Elective Specialization courses", semester = 5, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 23, name = "Communication Networks II", ects = 6, description = "Track Compulsory courses", semester = 5, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 24, name = "Communications Network I Lab", ects = 2, description = "Optional Laboratory courses", semester = 5, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 25, name = "Computer Architecture II", ects = 6, description = "Track Compulsory courses", semester = 5, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 26, name = "Computer Graphics I", ects = 6, description = "Elective Specialization courses", semester = 5, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 27, name = "Digital Signal Processing", ects = 6, description = "Track Compulsory courses", semester = 5, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 28, name = "Implementation of Database Management Systems", ects = 6, description = "Track Compulsory courses", semester = 5, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 29, name = "Numerical Analysis", ects = 6, description = "Track Compulsory courses", semester = 5, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 30, name = "Operating Systems", ects = 8, description = "Compulsory courses", semester = 5, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 31, name = "Parallel Systems", ects = 6, description = "Elective Specialization courses", semester = 5, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 32, name = "Principles of programming languages", ects = 6, description = "Elective Specialization courses", semester = 5, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 33, name = "Telecommunication Networks", ects = 6, description = "Elective Specialization courses", semester = 5, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 34, name = "Waves, Waveguides, Antennas (In Greek)", ects = 6, description = "Elective Specialization courses", semester = 5, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 35, name = "Analysis and Design of Software Systems", ects = 6, description = "Elective Specialization courses", semester = 6, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 36, name = "Compilers", ects = 6, description = "Track Compulsory courses", semester = 6, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 37, name = "Data Mining Techniques", ects = 6, description = "Elective Specialization courses", semester = 6, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 38, name = "Electronics", ects = 6, description = "Track Compulsory courses", semester = 6, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 39, name = "Electronics Laboratory", ects = 2, description = "Elective Specialization courses", semester = 6, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 40, name = "Information Theory", ects = 6, description = "Track Compulsory courses", semester = 6, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 41, name = "Internet Application Technologies", ects = 6, description = "Elective Specialization courses", semester = 6, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 42, name = "Logic Programming", ects = 6, description = "Elective Specialization courses", semester = 6, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 43, name = "Mathematics for Computer Science", ects = 6, description = "Track Compulsory courses", semester = 6, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 44, name = "Network Management", ects = 6, description = "Track Compulsory courses", semester = 6, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 45, name = "Pattern Recognition - Machine Learning", ects = 6, description = "Elective Specialization courses", semester = 6, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 46, name = "Scientific Computing", ects = 6, description = "Elective Specialization courses", semester = 6, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 47, name = "Stochastic Signals", ects = 6, description = "Elective Specialization courses", semester = 6, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 48, name = "Systems Programming", ects = 8, description = "Compulsory courses", semester = 6, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 49, name = "Theory of Computation", ects = 6, description = "Track Compulsory courses", semester = 6, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 50, name = "Wireless Sensor Networks", ects = 6, description = "Elective Specialization courses", semester = 6, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 51, name = "Advanced Scientific Computing", ects = 6, description = "Elective Specialization courses", semester = 7, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 52, name = "Advanced Topics on Algorithms", ects = 6, description = "Elective Specialization courses", semester = 7, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 53, name = "Algorithmic Operations Research", ects = 6, description = "Elective Specialization courses", semester = 7, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 54, name = "Artificial Intelligence II", ects = 6, description = "Elective Specialization courses", semester = 7, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 55, name = "Computational Complexity", ects = 6, description = "Elective Specialization courses", semester = 7, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 56, name = "Didactics of Informatics", ects = 6, description = "Elective Specialization courses", semester = 7, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 57, name = "Digital Accessibility and computer-based Assistive Technologies", ects = 6, description = "Elective Specialization courses", semester = 7, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 58, name = "Digital Communications", ects = 6, description = "Elective Specialization courses", semester = 7, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 59, name = "Human-Computer Interaction", ects = 6, description = "Elective Specialization courses", semester = 7, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 60, name = "Information and Communications Technology (ICT) in Learning", ects = 6, description = "Elective Specialization courses", semester = 7, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 61, name = "Information Systems", ects = 6, description = "Elective Specialization courses", semester = 7, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 62, name = "Mobile and Wireless Communication Systems", ects = 6, description = "Elective Specialization courses", semester = 7, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 63, name = "Number Theory", ects = 6, description = "Elective Specialization courses", semester = 7, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 64, name = "Optical Communications and Optical Networks", ects = 6, description = "Elective Specialization courses", semester = 7, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 65, name = "Real-Time Digital Signal Processing Systems", ects = 6, description = "Elective Specialization courses", semester = 7, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 66, name = "Semantics of Programming Languages", ects = 6, description = "Elective Specialization courses", semester = 7, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 67, name = "Software Development for Information Systems", ects = 8, description = "Project", semester = 7, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 68, name = "Software Development for Network and Telecommunication Systems", ects = 8, description = "Project", semester = 7, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 69, name = "Special Topics on Computing Systems and Computer Science Applications", ects = 4, description = "Elective Specialization courses", semester = 7, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 70, name = "Structure and Institutions of the European Union", ects = 2, description = "General Education", semester = 7, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 71, name = "Computational Geometry", ects = 6, description = "Elective Specialization courses", semester = 8, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 72, name = "Computer Music / Music Informatics", ects = 4, description = "Elective Specialization courses", semester = 8, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 73, name = "Computer Systems Protection and Security", ects = 6, description = "Elective Specialization courses", semester = 8, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 74, name = "Cryptography", ects = 6, description = "Elective Specialization courses", semester = 8, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 75, name = "Digital Systems Design - VHDL", ects = 8, description = "Elective Specialization courses", semester = 8, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 76, name = "e-Government", ects = 4, description = "Elective Specialization courses", semester = 8, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 77, name = "Graph Theory", ects = 6, description = "Elective Specialization courses", semester = 8, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 78, name = "Hardware / Software Codesing for Embedded Systems", ects = 8, description = "Project", semester = 8, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 79, name = "History of Computing and Telecommunications", ects = 4, description = "Elective Specialization courses", semester = 8, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 80, name = "Innovation and Entrepreneurship", ects = 4, description = "Elective Specialization courses", semester = 8, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 81, name = "Microeconomic Analysis", ects = 4, description = "Elective Specialization courses", semester = 8, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 82, name = "Parallel Algorithms", ects = 6, description = "Elective Specialization courses", semester = 8, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 83, name = "Photonics", ects = 6, description = "Elective Specialization courses", semester = 8, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 84, name = "Project Management and Techniques for Presenting and Writing Scientific Reports", ects = 2, description = "General Education", semester = 8, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 85, name = "School Classroom and Microteaching", ects = 6, description = "Elective Specialization courses", semester = 8, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 86, name = "Semantics of Programming Languages", ects = 6, description = "Elective Specialization courses", semester = 8, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 87, name = "Software Development for Algorithmic Problems", ects = 8, description = "Project", semester = 8, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 88, name = "Software Engineering", ects = 6, description = "Elective Specialization courses", semester = 8, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 89, name = "Special Topics in Communications and Signal Processing: Transmission Lines, waveguides and optical fibers", ects = 4, description = "Elective Specialization courses", semester = 8, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 90, name = "Special topics in Theoretical Informatics: Algorithms in Structural Bioinformatics", ects = 6, description = "Elective Specialization courses", semester = 8, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 91, name = "Special Topics on Computing Systems and Computer Science Applications", ects = 4, description = "Elective Specialization courses", semester = 8, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 92, name = "Speech and Natural Language Processing", ects = 6, description = "Elective Specialization courses", semester = 8, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 93, name = "Stochastic Signals", ects = 6, description = "Elective Specialization courses", semester = 8, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 94, name = "Wireless Links", ects = 6, description = "Elective Specialization courses", semester = 8, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow }
        };

        public static void SeedCoursesDeclarationApi(this WebApplication app)
        {
            using (var db = new DataContext())
            {
                // create a student, to demonstrate functionality of the app
                if (!db.Students.Any())
                {
                    DateTime dt = DateTime.UtcNow;
                    db.Students.Add(new Student()
                    {
                        id = ,
                        firstName = "Konstantina",
                        lastName = "Stafyla",
                        code = "1115201700000",
                        email = "sdi1700000@di.uoa.gr",
                        phone = "6900000000",
                        department = "Informatics and Telecommunications",
                        faculty = "",
                        semester = 7,
                        createdAt = dt,
                        updatedAt = dt
                    });
                    db.SaveChanges();
                }

                // initialise Courses table with course contents
                if (!db.Courses.Any())
                {
                    // initialise Courses table with course contents
                    db.Courses.AddRange(_courses);
                    db.SaveChanges();
                    // TODO: initialise CoursesSpecializations table with course contents
                }


            }

        }
    }
}
