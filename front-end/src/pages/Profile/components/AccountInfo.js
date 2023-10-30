import Delimeter from "../../../components/Delimeter";
import InputField from "./InputField";

export default function AccountInfo({ data }) {
  return (
    <div className='account-info'>
      <Delimeter />
      <h2 className='section-title'>Account info</h2>
      
      <InputField
        label='First Name'
        type='text'
        name='firstName'
        data={data}
      />

      <InputField
        label='Last Name'
        type='text'
        name='lastName'
        data={data}
      />

      <InputField
        label='Email'
        type='email'
        name='email'
        data={data}
      />

      <InputField
        label='Phone'
        type='tel'
        name='phone'
        data={data}
      />
    </div>
  )
}