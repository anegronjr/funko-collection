import React, { Component } from 'react';
import Funko from './Funko';

class Category extends Component {
    render() {
        const { funkos, name } = this.props;
        const funkoItems = funkos.map(item => (
            <Funko imgPath={item.image} funkoName={item.name} />
        ));

        return (
        <div>
            <h1>{name}</h1>
            {funkoItems}
        </div>
        );
    }
}

export default Category;