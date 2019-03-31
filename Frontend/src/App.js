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

    componentDidMount() {
      fetch("https://localhost:44384/api/category")
        .then(res => res.json())
        .then(json => this.setState({ categories: json}))
    }



    render() {
        const categoryItems = this.state.categories.map(item => (
          <Category funkos={item.funkos} name={item.name} />
        ));
        return (
        <div className="App">
          {categoryItems}
        </div>
        );
    }
}

export default App;