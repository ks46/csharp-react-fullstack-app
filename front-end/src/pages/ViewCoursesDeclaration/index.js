import { Link } from "react-router-dom";

export default function ViewCoursesDeclaration() {
  return (
    <main>
      <h1>
        Courses Declaration for exams period Winter 2023 submitted successfully!
      </h1>

      <Link to={`/profile`}>
        Return to profile page
      </Link>
    </main>
  );
}