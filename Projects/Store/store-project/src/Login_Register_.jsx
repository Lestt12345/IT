import React, { useState } from 'react';
import './styles/Login_Register_.css'
import {
  MDBContainer,
  MDBTabs,
  MDBTabsItem,
  MDBTabsLink,
  MDBTabsContent,
  MDBTabsPane,
  MDBBtn,
  MDBInput,
  MDBCheckbox
}
from 'mdb-react-ui-kit';

function Login_Register_() {

  const [justifyActive, setJustifyActive] = useState('tab1');;

  const handleJustifyClick = (value) => {
    if (value === justifyActive) {
      return;
    }

    setJustifyActive(value);
  };

  return (
    <>
      <div className='d-flex items-center justify-content-center wh'>
        <MDBContainer className="d-flex flex-column MediaWidth">

          <MDBTabs pills justify className='mb-3 d-flex flex-row justify-content-between'>
            <MDBTabsItem className='mx-2'>
              <MDBTabsLink className="hov" onClick={() => handleJustifyClick('tab1')} active={justifyActive === 'tab1'}>
                Login
              </MDBTabsLink>
            </MDBTabsItem>
            <MDBTabsItem>
              <MDBTabsLink className="hov" onClick={() => handleJustifyClick('tab2')} active={justifyActive === 'tab2'}>
                Register
              </MDBTabsLink>
            </MDBTabsItem>
          </MDBTabs>

          <MDBTabsContent>

            <MDBTabsPane open={justifyActive === 'tab1'}>

              <MDBInput wrapperClass='mb-4' placeholder='Email address' id='form1' type='email'/>
              <MDBInput wrapperClass='mb-4' placeholder='Password' id='form2' type='password'/>

              <div className="d-flex justify-content-between mx-4 mb-4">
                <MDBCheckbox name='flexCheck' value='' id='flexCheckDefault' label='Remember me' />
                <a href="#" style={{ textDecoration: 'underline' }}>Forgot password?</a>
              </div>

              <MDBBtn className="mb-4 w-100">Sign in</MDBBtn>

            </MDBTabsPane>

            <MDBTabsPane open={justifyActive === 'tab2'}>

              <MDBInput wrapperClass='mb-4' placeholder='Username' id='form1' type='text'/>
              <MDBInput wrapperClass='mb-4' placeholder='Email' id='form1' type='email'/>
              <MDBInput wrapperClass='mb-4' placeholder='Password' id='form1' type='password'/>

              <div className='d-flex justify-content-center mb-4'>
                <MDBCheckbox name='flexCheck' id='flexCheckDefault' label='I have read and agree to the' required />
                <a href="/terms" style={{ color: 'blue', marginLeft: '5px' }} target='blank_'>terms</a>
              </div>


              <MDBBtn className="mb-4 w-100">Sign up</MDBBtn>

            </MDBTabsPane>

          </MDBTabsContent>

        </MDBContainer>
      </div>
    </>
  );
}

export default Login_Register_;