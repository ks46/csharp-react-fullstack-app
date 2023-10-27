function Course({ course, isChecked, updateSelectedCourses }) {
  // TODO: display specializations for each course
  return (
    <tr>
      <td className='checkbox-table-col'>
        <input
          type='checkbox'
          checked={isChecked}
          onChange={() => updateSelectedCourses(course.id)}
        />
      </td>
      <td className='course-table-col'>{course.name}</td>
      <td className='ects-table-col'>{course.ects}</td>
      <td className='type-table-col'>{course.description}</td>
      <td className='s-table-col'>B</td>
      <td className='s-table-col'></td>
      <td className='s-table-col'>B</td>
      <td className='s-table-col'>Y</td>
      <td className='s-table-col'></td>
      <td className='s-table-col'></td>
    </tr>
  );
}

export default function CoursesList({ courses, selectedCourses, updateSelectedCourses }) {
  return (
    <div className='courses-list'>
      <table>
        <thead>
          <tr>
            <th className='checkbox-table-col'></th>
            <th className='course-table-col'>Course</th>
            <th className='ects-table-col'>ECTS</th>
            <th className='type-table-col'>Category</th>
            <th className='s-table-col'>S1</th>
            <th className='s-table-col'>S2</th>
            <th className='s-table-col'>S3</th>
            <th className='s-table-col'>S4</th>
            <th className='s-table-col'>S5</th>
            <th className='s-table-col'>S6</th>
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