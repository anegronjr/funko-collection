import React, { Component } from 'react';
import Funko from './Funko';

class Category extends Component {
    
    funkoNameChange = event => {
        this.props.setFunkoName(event.target.value);
    };

    newNameChange = event => {
        this.props.setNewName(event.target.value);
    }

    newImageChange = event => {
        this.props.setNewImage(event.target.value);
    }

    saveChanges = () => {
        this.props.addNewFunko(this.props.categoryId);
    }

    render() {
        const { funkos, name, updateFunko, funkoText, image } = this.props;
        const funkoItems = funkos.map(item => (
            <Funko 
                imgPath={item.image} 
                funkoName={item.name} 
                funkoId={item.funkoId} 
                categoryId={item.categoryId} 
                updateFunko={updateFunko}
                funkoNameChange={this.funkoNameChange}  
                funkoText={funkoText}  
            />
        ));

        return (
        <div className="category">
            <h1>{name}</h1>
            <button>Add New Funko</button>
            <div className={`add-form${this.props.categoryId}`}>
                <input className={`add-name${this.props.categoryId}`} value={funkoText} onChange={this.newNameChange} type="text" />
                <input className={`add-image${this.props.categoryId}`}  value={image} onChange={this.newImageChange} type="text" />
                <button onClick={this.saveChanges}>Save Changes</button>
            </div>
            <div className="funko-container">
            {funkoItems}
            </div>
        </div>
        );
    }
}

export default Category;