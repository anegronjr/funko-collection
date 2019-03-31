import React, { Component } from 'react';
import Category from './components/Category';
import './css/app.css';

class App extends Component {
    constructor(){
      super();
      this.state = {
        categories: [],
        name: "",
        image: ""     
      }
    }

    componentDidMount() {
      fetch("https://localhost:44384/api/category")
        .then(res => res.json())
        .then(json => this.setState({ categories: json}))
    }

    addNewFunko = (categoryId) => {
      const createdFunko = {
        name: this.state.name,
        image: this.state.image,
        categoryId: categoryId
      };

      fetch("https://localhost:44384/api/funko", {
        method: "POST",
        headers: {
          "Content-type": "application/json"
        },
        body: JSON.stringify(createdFunko)
      })
      .then(res => {
        if (res.ok) {
          const categoryIndex = categoryId - 1;
          const newFunkos = [...this.state.categories[categoryIndex].funkos, createdFunko];
          const updatedCategory = this.state.categories[categoryIndex];
          updatedCategory.funkos = newFunkos;
          const newCategories = this.state.categories;
          newCategories[categoryIndex] = updatedCategory;

          this.setState({ categories: newCategories });
        }
      });
    };

    setNewName = text => {
      this.setState({ name: text });
    };

    setNewImage = text => {
      this.setState({ image: text });
    };

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
            categoryId = {item.categoryId}
            updateFunko={this.updateFunko}
            setFunkoName={this.setFunkoName}
            funkoText={this.name}  
            image={this.image}
            addNewFunko={this.addNewFunko}
            setNewName={this.setNewName}
            setNewImage={this.setNewImage}
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