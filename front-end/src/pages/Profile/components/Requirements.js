import greenTick from '../../../assets/green-tick-icon.svg'
export default function Requirements({ data }) {

  return (
    <div>
      <h2>Undergraduate Study Program Requirements</h2>
      <img src={greenTick} alt='green tick icon'/>
      {
        data.map(r => <p>{r.text}</p>)
      }
    </div>
  );
}