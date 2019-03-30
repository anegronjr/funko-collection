import React, { Component } from 'react';
import Category from './components/Category';
import './css/app.css';

class App extends Component {
    constructor(){
      super();
      this.state = {
        categories: []        
      }
    }

    

    render() {
        return (
        <div className="App">
          <Category />
        </div>
        );
    }
}

export default App;