import React, { Component } from 'react';
import Funko from './Funko';

class Category extends Component {
    render() {
        const { funkos, name } = this.props;
        const funkoItems = funkos.map(item => (
            <Funko imgPath={item.image} funkoName={item.name} funkoId={item.funkoId} />
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