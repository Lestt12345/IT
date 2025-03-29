import { useState } from 'react'
import Header_ from './Header_.jsx'
import Footer_ from './Footer_.jsx'

function Main_() {
  const [count, setCount] = useState(0)

  return (
    <>
      <Header_ />
      <div>
        future MAIN
      </div>
      <Footer_ />
    </>
  )
}

export default Main_
