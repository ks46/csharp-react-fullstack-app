import { Link } from "react-router-dom";

function OptionItem({ text, isActive, handleClick}) {
  const activeClass = isActive ? 'active' : 'inactive'

  return (
    <li
      className={`semester-item ${activeClass}-bg`}
      onClick={handleClick}
    >
      <p className={activeClass}>
        {text}
      </p>
    </li>
  );
}

function PreviewButton({isActive, setSemesterTab }) {
  return (
    <OptionItem
      text={'Preview'}
      isActive={isActive}
      handleClick={() => setSemesterTab(0)}
    />
  );
}

function SubmitButton({ handleSubmit }) {
  return (
    <Link to={'/coursedeclarationform/success'} className='semester-item'>
      <OptionItem
        text='Submit'
        handleClick={handleSubmit}
        />
    </Link>
  );
}

function SemesterItem({ semesterNo, isActive, setSemesterTab }) {
  return (
    <OptionItem
      text= {`Semester ${semesterNo}`}
      isActive={isActive}
      handleClick={() => setSemesterTab(semesterNo)}
    />
  )
}

export default function ChooseSemester({ semesterNo, setSemesterTab, handleSubmit }) {
  
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

        <PreviewButton isActive={semesterNo === 0} setSemesterTab={setSemesterTab} />

        <SubmitButton handleSubmit={handleSubmit} />
      </ul>
    </nav>
  )
}