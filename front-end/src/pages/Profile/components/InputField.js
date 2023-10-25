export default function InputField({ label, type, name, data }) {
  return (
    <label className='input-field'>
      <p className='label-name label-text'>{label}</p>
      <input
        type={type}
        name={name}
        value={data[name]}
        disabled={true}
      />
    </label>
  )
}