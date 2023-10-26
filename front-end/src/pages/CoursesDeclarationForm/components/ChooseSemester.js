function SemesterItem({ semesterNo, isActive, setSemesterTab }) {
  const activeClass = isActive ? 'active' : 'inactive'

  return (
    <li
      className={`semester-item ${activeClass}-bg`}
      onClick={() => setSemesterTab(semesterNo)}
    >
      <p className={activeClass}>
        {`Semester ${semesterNo}`}</p>
    </li>
  )
}

export default function ChooseSemester({ semesterNo, setSemesterTab }) {
  
  return (
    <nav className='choose-semester'>
      <ul className='semester-list'>
        <SemesterItem semesterNo={1} isActive={semesterNo === 1} setSemesterTab={setSemesterTab} />
        <SemesterItem semesterNo={2} isActive={semesterNo === 2} setSemesterTab={setSemesterTab} />
        <SemesterItem semesterNo={3} isActive={semesterNo === 3} setSemesterTab={setSemesterTab} />
        <SemesterItem semesterNo={4} isActive={semesterNo === 4} setSemesterTab={setSemesterTab} />
        <SemesterItem semesterNo={5} isActive={semesterNo === 5} setSemesterTab={setSemesterTab} />
        <SemesterItem semesterNo={6} isActive={semesterNo === 6} setSemesterTab={setSemesterTab} />
        <SemesterItem semesterNo={7} isActive={semesterNo === 7} setSemesterTab={setSemesterTab} />
        <SemesterItem semesterNo={8} isActive={semesterNo === 8} setSemesterTab={setSemesterTab} />
      </ul>
    </nav>
  )
}