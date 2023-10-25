import { useState } from "react";
import ChooseSemester from "./components/ChooseSemester";
import CoursesList from "./components/CoursesList";

export default function CoursesDeclarationForm() {
  const [semesterTab, setSemesterTab] = useState(1)
  // TODO: fetch all courses for student with such studentId


  return (
    <main className='main cd-form'>
      <ChooseSemester semesterNo={semesterTab} setSemesterTab={setSemesterTab} />
      <CoursesList />
    </main>
  )
}