function Course({ course, isChecked, updateSelectedCourses }) {
  // TODO: display specializations for each course
  return (
    <tr className={isChecked ? 'checked' : ''}>
      <td className='table-col checkbox-table-col'>
        <input
          type='checkbox'
          checked={isChecked}
          onChange={() => updateSelectedCourses(course.id)}
        />
      </td>
      <td className='table-col course-table-col'>{course.name}</td>
      <td className='table-col ects-table-col'>{course.ects}</td>
      <td className='table-col type-table-col'>{course.description}</td>
      <td className='table-col s-table-col'>B</td>
      <td className='table-col s-table-col'></td>
      <td className='table-col s-table-col'>B</td>
      <td className='table-col s-table-col'>Y</td>
      <td className='table-col s-table-col'></td>
      <td className='table-col s-table-col'></td>
    </tr>
  );
}

export default function CoursesList({ courses, selectedCourses, updateSelectedCourses }) {
  return (
    <div className='courses-list'>
      <table>
        <thead>
          <tr>
            <th className='table-col checkbox-table-col'></th>
            <th className='table-col course-table-col'>Course</th>
            <th className='table-col ects-table-col'>ECTS</th>
            <th className='table-col type-table-col'>Category</th>
            <th className='table-col s-table-col'>S1</th>
            <th className='table-col s-table-col'>S2</th>
            <th className='table-col s-table-col'>S3</th>
            <th className='table-col s-table-col'>S4</th>
            <th className='table-col s-table-col'>S5</th>
            <th className='table-col s-table-col'>S6</th>
          </tr>
        </thead>
        <tbody>
          { 
            courses.map(c => <Course course={c} isChecked={selectedCourses.includes(c.id)}
            updateSelectedCourses={updateSelectedCourses}
            key={c.id} />)
          }
        </tbody>
      </table>
    </div>
  )
}