import React, { Component } from 'react';

class Funko extends Component {
    render() {
        const { imgPath, funkoName, funkoCategory } = this.props;

        return (
        <div className="funko">
            <img src={this.imgPath} />
            <span>{this.funkoName}</span>
            <span>{this.funkoCategory}</span>
        </div>
        );
    }
}

export default Funko;