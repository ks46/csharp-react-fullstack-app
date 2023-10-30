import Delimeter from "../../../components/Delimeter";
import InputField from "./InputField";

export default function StudiesInfo({data}) {
  return (
    <div className='studies-info'>
      <Delimeter />
      <h2 className='section-title'>Studies Info</h2>

      <InputField
        label='Identification Number'
        type='text'
        name='code'
        data={data}
      />

      <InputField
        label='Department'
        type='text'
        name='department'
        data={data}
      />

      <InputField
        label='Faculty'
        type='text'
        name='faculty'
        data={data}
      />

      <InputField
        label='Semester'
        type='text'
        name='semester'
        data={data}
      />
    </div>
  )
}