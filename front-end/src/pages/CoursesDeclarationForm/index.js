import { useEffect, useState } from "react";
import ChooseSemester from "./components/ChooseSemester";
import CoursesList from "./components/CoursesList";
import '../../styles/cd_form.css'

export default function CoursesDeclarationForm() {
  const [formData, setFormData] = useState([])
  const [courses, setCourses] = useState([])
  const [semesterTab, setSemesterTab] = useState(1)

  async function getCourses() {
    // TODO: insert studentId parameter into the url to fetch data
    const response = await fetch(`https://localhost:7201/students/1/courses`)
    const json = await response.json()
    setCourses(json)
  }

  useEffect(() => {
    getCourses()
  }, [])

  let filteredCourses = courses.filter(c => c.semester === semesterTab)

  return (
    <main className='main cd-page'>
      <h1 className='title'>Courses Declaration Form</h1>
      <div className='cd-form'>
        <ChooseSemester semesterNo={semesterTab} setSemesterTab={setSemesterTab} />
        <CoursesList courses={filteredCourses} />
      </div>
    </main>
  )
}