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
            new Course() { id = 94, name = "Wireless Links", ects = 6, description = "Elective Specialization courses", semester = 8, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 95, name = "Thesis I", ects = 8, description = "Thesis/Internship", semester = 7, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 96, name = "Thesis II", ects = 8, description = "Thesis/Internship", semester = 8, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 97, name = "Internship I", ects = 8, description = "Thesis/Internship", semester = 7, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Course() { id = 98, name = "Internship II", ects = 8, description = "Thesis/Internship", semester = 8, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow }
        };

        private static List<CoursesSpecializations> _specializations = new List<CoursesSpecializations>()
        {
            new CoursesSpecializations() { courseId = 8, specializationId = 6, category = "B" },
            new CoursesSpecializations() { courseId = 22, specializationId = 2, category = "B" },
            new CoursesSpecializations() { courseId = 22, specializationId = 3, category = "B" },
            new CoursesSpecializations() { courseId = 23, specializationId = 5, category = "Y" },
            new CoursesSpecializations() { courseId = 25, specializationId = 3, category = "B" },
            new CoursesSpecializations() { courseId = 25, specializationId = 4, category = "Y" },
            new CoursesSpecializations() { courseId = 26, specializationId = 1, category = "B" },
            new CoursesSpecializations() { courseId = 26, specializationId = 6, category = "B" },
            new CoursesSpecializations() { courseId = 27, specializationId = 6, category = "Y" },
            new CoursesSpecializations() { courseId = 28, specializationId = 2, category = "Y" },
            new CoursesSpecializations() { courseId = 28, specializationId = 3, category = "Y" },
            new CoursesSpecializations() { courseId = 29, specializationId = 1, category = "Y" },
            new CoursesSpecializations() { courseId = 31, specializationId = 3, category = "B" },
            new CoursesSpecializations() { courseId = 31, specializationId = 4, category = "B" },
            new CoursesSpecializations() { courseId = 32, specializationId = 1, category = "B" },
            new CoursesSpecializations() { courseId = 32, specializationId = 2, category = "B" },
            new CoursesSpecializations() { courseId = 33, specializationId = 5, category = "B" },
            new CoursesSpecializations() { courseId = 34, specializationId = 5, category = "B" },
            new CoursesSpecializations() { courseId = 35, specializationId = 3, category = "B" },
            new CoursesSpecializations() { courseId = 36, specializationId = 3, category = "Y" },
            new CoursesSpecializations() { courseId = 36, specializationId = 4, category = "B" },
            new CoursesSpecializations() { courseId = 37, specializationId = 2, category = "B" },
            new CoursesSpecializations() { courseId = 38, specializationId = 4, category = "Y" },
            new CoursesSpecializations() { courseId = 39, specializationId = 4, category = "B" },
            new CoursesSpecializations() { courseId = 41, specializationId = 3, category = "B" },
            new CoursesSpecializations() { courseId = 41, specializationId = 5, category = "B" },
            new CoursesSpecializations() { courseId = 42, specializationId = 2, category = "B" },
            new CoursesSpecializations() { courseId = 43, specializationId = 1, category = "Y" },
            new CoursesSpecializations() { courseId = 44, specializationId = 5, category = "Y" },
            new CoursesSpecializations() { courseId = 45, specializationId = 2, category = "B" },
            new CoursesSpecializations() { courseId = 45, specializationId = 6, category = "B" },
            new CoursesSpecializations() { courseId = 46, specializationId = 1, category = "B" },
            new CoursesSpecializations() { courseId = 47, specializationId = 5, category = "B" },
            new CoursesSpecializations() { courseId = 47, specializationId = 6, category = "B" },
            new CoursesSpecializations() { courseId = 49, specializationId = 2, category = "Y" },
            new CoursesSpecializations() { courseId = 50, specializationId = 4, category = "B" },
            new CoursesSpecializations() { courseId = 50, specializationId = 5, category = "B" },
            new CoursesSpecializations() { courseId = 52, specializationId = 1, category = "B" },
            new CoursesSpecializations() { courseId = 53, specializationId = 1, category = "B" },
            new CoursesSpecializations() { courseId = 53, specializationId = 2, category = "B" },
            new CoursesSpecializations() { courseId = 53, specializationId = 6, category = "B" },
            new CoursesSpecializations() { courseId = 54, specializationId = 2, category = "B" },
            new CoursesSpecializations() { courseId = 54, specializationId = 3, category = "B" },
            new CoursesSpecializations() { courseId = 55, specializationId = 1, category = "B" },
            new CoursesSpecializations() { courseId = 58, specializationId = 5, category = "B" },
            new CoursesSpecializations() { courseId = 59, specializationId = 2, category = "B" },
            new CoursesSpecializations() { courseId = 59, specializationId = 3, category = "B" },
            new CoursesSpecializations() { courseId = 62, specializationId = 5, category = "B" },
            new CoursesSpecializations() { courseId = 64, specializationId = 4, category = "B" },
            new CoursesSpecializations() { courseId = 64, specializationId = 5, category = "B" },
            new CoursesSpecializations() { courseId = 65, specializationId = 4, category = "B" },
            new CoursesSpecializations() { courseId = 65, specializationId = 6, category = "B" },
            new CoursesSpecializations() { courseId = 66, specializationId = 1, category = "B" },
            new CoursesSpecializations() { courseId = 66, specializationId = 2, category = "B" },
            new CoursesSpecializations() { courseId = 71, specializationId = 1, category = "B" },
            new CoursesSpecializations() { courseId = 73, specializationId = 3, category = "B" },
            new CoursesSpecializations() { courseId = 74, specializationId = 1, category = "B" },
            new CoursesSpecializations() { courseId = 75, specializationId = 4, category = "B" },
            new CoursesSpecializations() { courseId = 77, specializationId = 1, category = "B" },
            new CoursesSpecializations() { courseId = 86, specializationId = 1, category = "B" },
            new CoursesSpecializations() { courseId = 86, specializationId = 2, category = "B" },
            new CoursesSpecializations() { courseId = 88, specializationId = 3, category = "B" },
            new CoursesSpecializations() { courseId = 92, specializationId = 6, category = "B" },
            new CoursesSpecializations() { courseId = 93, specializationId = 5, category = "B" },
            new CoursesSpecializations() { courseId = 93, specializationId = 6, category = "B" }
        };

        private static List<Declaration> _declarations = new List<Declaration>()
        {
            new Declaration() { id = 1, studentId = 1, period = "Winter 2017-2018", createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Declaration() { id = 2, studentId = 1, period = "Spring 2017-2018", createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Declaration() { id = 3, studentId = 1, period = "September 2017-2018", createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Declaration() { id = 4, studentId = 1, period = "Winter 2018-2019", createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Declaration() { id = 5, studentId = 1, period = "Spring 2018-2019", createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new Declaration() { id = 6, studentId = 1, period = "September 2018-2019", createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow }
        };

        private static List<CoursesDeclarations> _coursesDeclarations = new List<CoursesDeclarations>()
        {
            new CoursesDeclarations() { courseId = 1, declarationId = 1, grade = 8.0M, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new CoursesDeclarations() { courseId = 2, declarationId = 1, grade = 8.5M, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new CoursesDeclarations() { courseId = 3, declarationId = 1, grade = 9.0M, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new CoursesDeclarations() { courseId = 4, declarationId = 1, grade = 3.0M, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new CoursesDeclarations() { courseId = 5, declarationId = 1, grade = 9.0M, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new CoursesDeclarations() { courseId = 7, declarationId = 2, grade = 8.0M, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new CoursesDeclarations() { courseId = 9, declarationId = 2, grade = 0.0M, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new CoursesDeclarations() { courseId = 10, declarationId = 2, grade = 0.0M, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new CoursesDeclarations() { courseId = 11, declarationId = 2, grade = 5.0M, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new CoursesDeclarations() { courseId = 4, declarationId = 3, grade = 9.0M, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new CoursesDeclarations() { courseId = 9, declarationId = 3, grade = 7.0M, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new CoursesDeclarations() { courseId = 10, declarationId = 3, grade = 7.0M, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new CoursesDeclarations() { courseId = 70, declarationId = 4, grade = 7.0M, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow },
            new CoursesDeclarations() { courseId = 84, declarationId = 4, grade = 8.0M, createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow }
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
                        id = 1,
                        firstName = "Konstantina",
                        lastName = "Stafyla",
                        code = "1115201700000",
                        email = "sdi1700000@di.uoa.gr",
                        phone = "6900000000",
                        department = "Informatics and Telecommunications",
                        faculty = "School of Sciences",
                        semester = 5,
                        createdAt = dt,
                        updatedAt = dt
                    });
                    db.SaveChanges();
                }

                // initialise Courses table with course contents
                if (!db.Courses.Any())
                {
                    db.Courses.AddRange(_courses);
                    db.SaveChanges();
                }

                // initialise CoursesSpecializations table with course contents
                if (!db.CoursesSpecializations.Any())
                {
                    db.CoursesSpecializations.AddRange(_specializations);
                    db.SaveChanges();
                }

                // initialise Declarations table
                if (!db.Declarations.Any())
                {
                    db.Declarations.AddRange(_declarations);
                    db.SaveChanges();
                }

                // initialise CoursesDeclarations table
                if (!db.CoursesDeclarations.Any())
                {
                    db.CoursesDeclarations.AddRange(_coursesDeclarations);
                    db.SaveChanges();
                }
            }

        }
    }
}
