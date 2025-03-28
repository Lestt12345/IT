import { useState } from 'react'
import Header_ from './Header_.jsx'
import Footer_ from './Footer_.jsx'
import Login_Register_ from './Login_Register_.jsx'

function Main_() {
  const [count, setCount] = useState(0)

  return (
    <>
      <Header_ />
      <div>
        future MAIN
      </div>
      <Footer_ />
      <Login_Register_ />
    </>
  )
}

export default Main_
