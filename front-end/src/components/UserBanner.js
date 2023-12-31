import { Link } from "react-router-dom"

export default function UserBanner({ name, firstName, lastName, id }) {
  // TODO: get rid of name property
  const initials = name ? 'KS'
                : firstName[0] + lastName[0]
  
  return (
    // TODO: use appropriate links below
    <Link to={`/profile/${id}`}> 
      <span className='user-banner'>{initials}</span>
    </Link>
  )
}