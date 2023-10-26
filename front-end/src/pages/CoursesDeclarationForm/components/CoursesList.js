function Course({ course }) {
  // TODO: display specializations for each course
  return (
    <tr>
      <td className='course-table-col'>{course.name}</td>
      <td className='ects-table-col'>{course.ects}</td>
      <td className='type-table-col'>{course.description}</td>
      <td className='s1-table-col'></td>
      <td className='s2-table-col'></td>
      <td className='s3-table-col'></td>
      <td className='s4-table-col'></td>
      <td className='s5-table-col'></td>
      <td className='s6-table-col'></td>
    </tr>
  );
}


export default function CoursesList({ courses }) {
  console.log(courses)

  return (
    <div className='courses-list'>
      <table>
        <thead>
          <tr>
            <th className='course-table-col'>Course</th>
            <th className='ects-table-col'>ECTS</th>
            <th className='type-table-col'>Category</th>
            <th className='s1-table-col'>S1</th>
            <th className='s2-table-col'>S2</th>
            <th className='s3-table-col'>S3</th>
            <th className='s4-table-col'>S4</th>
            <th className='s5-table-col'>S5</th>
            <th className='s6-table-col'>S6</th>
          </tr>
        </thead>
        <tbody>
          {
            courses.map(c => <Course course={c} key={c.id} />)
          }
        </tbody>
      </table>
    </div>
  )
}