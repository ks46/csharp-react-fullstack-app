import AccountInfo from "./AccountInfo";
import StudiesInfo from "./StudiesInfo";

export default function ProfileInfo({ user }) {

  return  (
    <form className='profile-form'>
      <div className='row'>
        <AccountInfo data={user} />
        <StudiesInfo data={user} />

        {/* TODO: add info about courses declarations */}
      </div>
    </form>
  )

}