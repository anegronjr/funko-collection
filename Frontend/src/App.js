import React, { Component } from 'react';
import Category from './components/Category';
import './css/app.css';

class App extends Component {
    constructor(){
      super();
      this.state = {
        categories: [],
        name: ""     
      }
    }

    componentDidMount() {
      fetch("https://localhost:44384/api/category")
        .then(res => res.json())
        .then(json => this.setState({ categories: json}))
    }

    updateFunko = (newFunkoId, newCategoryId, newImage) => {
      const newFunko = {
        name: this.state.name,
        funkoId: newFunkoId,
        categoryId: newCategoryId,
        image: newImage
      };

      const url = "https://localhost:44384/api/funko/" + newFunkoId;

      fetch(url, {
        method: "POST",
        headers: {
          "Content-type": "application/json"
        },
        body: JSON.stringify(newFunko)
      })
      .then(res => {
        if (res.ok) {
          const categoryIndex = newCategoryId - 1;
          const updatedFunkos = [...this.state.categories[categoryIndex].funkos]
          let oldFunko = 0;
          updatedFunkos.forEach((funko, index) => {
            if (funko.funkoId === newFunkoId){
              oldFunko = index;
            }
          });
          updatedFunkos[oldFunko] = newFunko;
          const updatedCategory = this.state.category[categoryIndex];
          updatedCategory.funkos = updatedFunkos;
          const newCategories = this.state.categories;
          newCategories[categoryIndex] = updatedCategory;
          this.setState({categories: newCategories});
        }
      });
    };

    setFunkoName = text => {
      this.setState({ name: text })
    }

    render() {
        const categoryItems = this.state.categories.map(item => (
          <Category 
            funkos={item.funkos} 
            name={item.name} 
            updateFunko={this.updateFunko}
            setFunkoName={this.setFunkoName}
            funkoText={this.name}  
          />
        ));
        return (
        <div className="App">
          {categoryItems}
        </div>
        );
    }
}

export default App;