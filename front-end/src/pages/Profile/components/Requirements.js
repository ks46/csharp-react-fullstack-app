import greenTick from '../../../assets/green-tick-icon.svg'

function Requirement({ data }) {
  return (
    <div className='row'>
      { data.done ?
        <img src={greenTick} alt='green tick icon'/>
        : <div></div>
      }
      <p>{data.text}</p>
    </div>
  );
}

export default function Requirements({ data }) {

  return (
    <div className='requirements-list'>
      <h2 className='section-title'>Undergraduate Study Program Requirements</h2>
      {
        data.map((r, index) => <Requirement data={r} key={`requirement-${index}`} />)
      }
    </div>
  );
}