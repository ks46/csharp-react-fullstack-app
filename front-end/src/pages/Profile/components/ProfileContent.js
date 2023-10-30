import { useParams } from "react-router-dom";
import UserBanner from "../../../components/UserBanner";
import { useEffect, useState } from "react";
import ProfileInfo from "./ProfileInfo";
import Delimeter from "../../../components/Delimeter";
import Requirements from "./Requirements";

function ProfileHeader({ user }) {
  return (
    <div className='profile-header'>
      <UserBanner firstName={user.firstName} lastName={user.lastName} id={user.id} />
      <h2 className='name'>{user.firstName} {user.lastName}</h2>
    </div>
  )
}

export default function ProfileContent() {
  const [user, setUser] = useState(null)
  const params = useParams()

  async function getUser() {
    // TODO: insert studentId parameter into the url to fetch data
    const response = await fetch(`https://localhost:7201/students/1`)
    const json = await response.json()
    setUser(json)
  }

  useEffect(() => {
    getUser()
  }, [])

  return (
    user &&
      <div className='profile-content box-container box-container-white'>
        <ProfileHeader user={user} />
        <ProfileInfo user={user} />

        <Delimeter />

        <Requirements data={user.requirements} />
      </div>
  )
}