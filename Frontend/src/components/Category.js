import React, { Component } from 'react';
import Funko from './Funko';

class Category extends Component {
    render() {
        const { funkos } = this.props;
        const funkoItems = funkos.map(item => (
            <Funko imgPath={item.imgPath} funkoName={item.funkoName} funkoCategory={item.funkoCategory} />
        ));

        return (
        <div>
            {funkoItems}
        </div>
        );
    }
}

export default Category;