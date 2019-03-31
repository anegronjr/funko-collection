import React, { Component } from 'react';
import Funko from './Funko';

class Category extends Component {
    
    funkoNameChange = event => {
        this.props.setFunkoName(event.target.value);
    };

    render() {
        const { funkos, name, updateFunko, funkoText } = this.props;
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
            <div className="funko-container">
            {funkoItems}
            </div>
        </div>
        );
    }
}

export default Category;