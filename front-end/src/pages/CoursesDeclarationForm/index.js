import { useEffect, useState } from "react";
import ChooseSemester from "./components/ChooseSemester";
import CoursesList from "./components/CoursesList";
import '../../styles/cd_form.css'
import { useNavigate } from "react-router-dom";

export default function CoursesDeclarationForm() {
  const [selectedCourses, setSelectedCourses] = useState([])
  const [courses, setCourses] = useState([])
  const [semesterTab, setSemesterTab] = useState(1)
  const navigate = useNavigate();

  const handleSubmit = (event) => {
    console.log('Submitting data:\n', selectedCourses)
    // TODO: insert studentId parameter into the url to fetch data
    fetch(`https://localhost:7201/students/1/declarations`, {
      method: 'POST',
      body: JSON.stringify(
        selectedCourses
      ),
      headers: {
        'Content-type': 'application/json; charset=UTF-8',
      },
    })
      .then((response) => response.json())
      .then((json) => {
        console.log(json)
        navigate("/coursedeclarationform/success")
      })
  }

  const updateSelectedCourses = (courseId) => {
    const index = selectedCourses.indexOf(courseId)
    if (index === -1) {
      // insert this courseId to selectedCourses
      setSelectedCourses([...selectedCourses, courseId])
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

  let filteredCourses = (semesterTab === 0) ? courses.filter(c => selectedCourses.includes(c.id)) : courses.filter(c => c.semester === semesterTab)

  return (
    <main className='main cd-page'>
      <h1 className='title'>Courses Declaration Form</h1>
      <div className='cd-form'>
        <ChooseSemester
          semesterNo={semesterTab}
          setSemesterTab={setSemesterTab}
          handleSubmit={handleSubmit}
        />
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