import { useEffect, useState } from "react";
import ChooseSemester from "./components/ChooseSemester";
import CoursesList from "./components/CoursesList";
import '../../styles/cd_form.css'

export default function CoursesDeclarationForm() {
  const [selectedCourses, setSelectedCourses] = useState([1,46])
  const [courses, setCourses] = useState([])
  const [semesterTab, setSemesterTab] = useState(1)

  const updateSelectedCourses = (courseId) => {
    const index = selectedCourses.indexOf(courseId)
    if (index === -1) {
      // insert this courseId to selectedCourses
      setSelectedCourses([courseId, ...selectedCourses])
    } else {
      const newSelectedCourses = [...selectedCourses]
      newSelectedCourses.splice(index, 1)
      setSelectedCourses(newSelectedCourses)
    }
  }

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
        {
          filteredCourses &&
          <CoursesList
            courses={filteredCourses}
            selectedCourses={selectedCourses}
            updateSelectedCourses={updateSelectedCourses}
          />
        }
      </div>
    </main>
  )
}