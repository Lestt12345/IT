import { useEffect, useState } from "react";

function useDbImitation() {
    const [categories, setCategories] = useState([]);
    const [products, setProducts] = useState([]);

    useEffect(() => {
        const tempCategories = ['category 1', 'category 2', 'category 3']; // тоже с бд, это для корректного присвоения категорий продуктам
        setCategories(tempCategories);
        setProducts([
            {
                id: 12,
                photo: ['photo1.png', 'photo2.png', 'photo3.png'],
                name: 'Product 12',
                description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis gravida, tellus eget tincidunt laoreet, nisl velit malesuada nunc, quis laoreet ligula nibh sit amet enim.',
                category: tempCategories[2],
                price: 4635,
            },
            {
                id: 28,
                photo: ['photo1.png', 'photo2.png', 'photo3.png'],
                name: 'Product 28',
                description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis gravida, tellus eget tincidunt laoreet, nisl velit malesuada nunc, quis laoreet ligula nibh sit amet enim.',
                category: tempCategories[0],
                price: 6123,
            },
            {
                id: 4,
                photo: ['photo1.png', 'photo2.png', 'photo3.png'],
                name: 'Product 4',
                description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis gravida, tellus eget tincidunt laoreet, nisl velit malesuada nunc, quis laoreet ligula nibh sit amet enim.',
                category: tempCategories[0],
                price: 2917,
            },
            {
                id: 15,
                photo: ['photo1.png', 'photo2.png', 'photo3.png'],
                name: 'Product 15',
                description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis gravida, tellus eget tincidunt laoreet, nisl velit malesuada nunc, quis laoreet ligula nibh sit amet enim.',
                category: tempCategories[2],
                price: 7758,
            },
            {
                id: 19,
                photo: ['photo1.png', 'photo2.png', 'photo3.png'],
                name: 'Product 19',
                description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis gravida, tellus eget tincidunt laoreet, nisl velit malesuada nunc, quis laoreet ligula nibh sit amet enim.',
                category: tempCategories[0],
                price: 8219,
            },
            {
                id: 7,
                photo: ['photo1.png', 'photo2.png', 'photo3.png'],
                name: 'Product 7',
                description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis gravida, tellus eget tincidunt laoreet, nisl velit malesuada nunc, quis laoreet ligula nibh sit amet enim.',
                category: tempCategories[0],
                price: 1501,
            },
            {
                id: 9,
                photo: ['photo1.png', 'photo2.png', 'photo3.png'],
                name: 'Product 9',
                description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis gravida, tellus eget tincidunt laoreet, nisl velit malesuada nunc, quis laoreet ligula nibh sit amet enim.',
                category: tempCategories[2],
                price: 9734,
            },
            {
                id: 23,
                photo: ['photo1.png', 'photo2.png', 'photo3.png'],
                name: 'Product 23',
                description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis gravida, tellus eget tincidunt laoreet, nisl velit malesuada nunc, quis laoreet ligula nibh sit amet enim.',
                category: tempCategories[1],
                price: 3339,
            },
            {
                id: 10,
                photo: ['photo1.png', 'photo2.png', 'photo3.png'],
                name: 'Product 10',
                description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis gravida, tellus eget tincidunt laoreet, nisl velit malesuada nunc, quis laoreet ligula nibh sit amet enim.',
                category: tempCategories[0],
                price: 5431,
            },
            {
                id: 20,
                photo: ['photo1.png', 'photo2.png', 'photo3.png'],
                name: 'Product 20',
                description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis gravida, tellus eget tincidunt laoreet, nisl velit malesuada nunc, quis laoreet ligula nibh sit amet enim.',
                category: tempCategories[1],
                price: 2597,
            },
            {
                id: 2,
                photo: ['photo1.png', 'photo2.png', 'photo3.png'],
                name: 'Product 2',
                description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis gravida, tellus eget tincidunt laoreet, nisl velit malesuada nunc, quis laoreet ligula nibh sit amet enim.',
                category: tempCategories[1],
                price: 8743,
            },
            {
                id: 25,
                photo: ['photo1.png', 'photo2.png', 'photo3.png'],
                name: 'Product 25',
                description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis gravida, tellus eget tincidunt laoreet, nisl velit malesuada nunc, quis laoreet ligula nibh sit amet enim.',
                category: tempCategories[0],
                price: 1534,
            },
            {
                id: 18,
                photo: ['photo1.png', 'photo2.png', 'photo3.png'],
                name: 'Product 18',
                description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis gravida, tellus eget tincidunt laoreet, nisl velit malesuada nunc, quis laoreet ligula nibh sit amet enim.',
                category: tempCategories[2],
                price: 4868,
            },
            {
                id: 6,
                photo: ['photo1.png', 'photo2.png', 'photo3.png'],
                name: 'Product 6',
                description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis gravida, tellus eget tincidunt laoreet, nisl velit malesuada nunc, quis laoreet ligula nibh sit amet enim.',
                category: tempCategories[2],
                price: 2399,
            },
            {
                id: 30,
                photo: ['photo1.png', 'photo2.png', 'photo3.png'],
                name: 'Product 30',
                description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis gravida, tellus eget tincidunt laoreet, nisl velit malesuada nunc, quis laoreet ligula nibh sit amet enim.',
                category: tempCategories[2],
                price: 9052,
            },
            {
                id: 5,
                photo: ['photo1.png', 'photo2.png', 'photo3.png'],
                name: 'Product 5',
                description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis gravida, tellus eget tincidunt laoreet, nisl velit malesuada nunc, quis laoreet ligula nibh sit amet enim.',
                category: tempCategories[1],
                price: 1277,
            },
            {
                id: 3,
                photo: ['photo1.png', 'photo2.png', 'photo3.png'],
                name: 'Product 3',
                description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis gravida, tellus eget tincidunt laoreet, nisl velit malesuada nunc, quis laoreet ligula nibh sit amet enim.',
                category: tempCategories[2],
                price: 3468,
            },
            {
                id: 1,
                photo: ['photo1.png', 'photo2.png', 'photo3.png'],
                name: 'Product 1',
                description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis gravida, tellus eget tincidunt laoreet, nisl velit malesuada nunc, quis laoreet ligula nibh sit amet enim.',
                category: tempCategories[0],
                price: 7240,
            },
            {
                id: 17,
                photo: ['photo1.png', 'photo2.png', 'photo3.png'],
                name: 'Product 17',
                description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis gravida, tellus eget tincidunt laoreet, nisl velit malesuada nunc, quis laoreet ligula nibh sit amet enim.',
                category: tempCategories[1],
                price: 4139,
            },
            {
                id: 26,
                photo: ['photo1.png', 'photo2.png', 'photo3.png'],
                name: 'Product 26',
                description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis gravida, tellus eget tincidunt laoreet, nisl velit malesuada nunc, quis laoreet ligula nibh sit amet enim.',
                category: tempCategories[1],
                price: 2894,
            },
            {
                id: 21,
                photo: ['photo1.png', 'photo2.png', 'photo3.png'],
                name: 'Product 21',
                description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis gravida, tellus eget tincidunt laoreet, nisl velit malesuada nunc, quis laoreet ligula nibh sit amet enim.',
                category: tempCategories[2],
                price: 8411,
            },
            {
                id: 27,
                photo: ['photo1.png', 'photo2.png', 'photo3.png'],
                name: 'Product 27',
                description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis gravida, tellus eget tincidunt laoreet, nisl velit malesuada nunc, quis laoreet ligula nibh sit amet enim.',
                category: tempCategories[2],
                price: 5519,
            },
            {
                id: 13,
                photo: ['photo1.png', 'photo2.png', 'photo3.png'],
                name: 'Product 13',
                description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis gravida, tellus eget tincidunt laoreet, nisl velit malesuada nunc, quis laoreet ligula nibh sit amet enim.',
                category: tempCategories[0],
                price: 6381,
            },
            {
                id: 14,
                photo: ['photo1.png', 'photo2.png', 'photo3.png'],
                name: 'Product 14',
                description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis gravida, tellus eget tincidunt laoreet, nisl velit malesuada nunc, quis laoreet ligula nibh sit amet enim.',
                category: tempCategories[1],
                price: 950,
            },
            {
                id: 24,
                photo: ['photo1.png', 'photo2.png', 'photo3.png'],
                name: 'Product 24',
                description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis gravida, tellus eget tincidunt laoreet, nisl velit malesuada nunc, quis laoreet ligula nibh sit amet enim.',
                category: tempCategories[2],
                price: 1759,
            },
            {
                id: 22,
                photo: ['photo1.png', 'photo2.png', 'photo3.png'],
                name: 'Product 22',
                description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis gravida, tellus eget tincidunt laoreet, nisl velit malesuada nunc, quis laoreet ligula nibh sit amet enim.',
                category: tempCategories[0],
                price: 3600,
            },
            {
                id: 8,
                photo: ['photo1.png', 'photo2.png', 'photo3.png'],
                name: 'Product 8',
                description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis gravida, tellus eget tincidunt laoreet, nisl velit malesuada nunc, quis laoreet ligula nibh sit amet enim.',
                category: tempCategories[1],
                price: 1875,
            },
            {
                id: 29,
                photo: ['photo1.png', 'photo2.png', 'photo3.png'],
                name: 'Product 29',
                description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis gravida, tellus eget tincidunt laoreet, nisl velit malesuada nunc, quis laoreet ligula nibh sit amet enim.',
                category: tempCategories[1],
                price: 7079,
            },
            {
                id: 11,
                photo: ['photo1.png', 'photo2.png', 'photo3.png'],
                name: 'Product 11',
                description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis gravida, tellus eget tincidunt laoreet, nisl velit malesuada nunc, quis laoreet ligula nibh sit amet enim.',
                category: tempCategories[1],
                price: 1000,
            },
            {
                id: 16,
                photo: ['photo1.png', 'photo2.png', 'photo3.png'],
                name: 'Product 16',
                description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis gravida, tellus eget tincidunt laoreet, nisl velit malesuada nunc, quis laoreet ligula nibh sit amet enim.',
                category: tempCategories[0],
                price: 6588,
            }
        ]);
    }, []);
    
    const filteredProducts = (filter, option = '') => {
        if (products.length === 0) return [];

        let result = [...products];
        let filteredProducts = [];
        
        switch(filter) {
            case 'price':
                if (option === 'toLow') {
                    result.sort((a, b) => a.price - b.price);
                } else if (option === 'toHigh') {
                    result.sort((a, b) => b.price - a.price);
                }
                break;
            case 'name':
                result.sort((a, b) => a.name.localeCompare(b.name));
                break;
            case 'category':
                if (option && categories.includes(option)) {
                    result = result.filter(product => product.category === option);
                }
                break;
            default:
                break;
        }

        filteredProducts = result.map(({ id, photo, name, description, price }) => ({
            id,
            photo,
            name,
            description,
            price
        }));

        return filteredProducts;
    };

    const productDetail = (id) => {
        return products.find(product => product.id === id) || null;
    };

    return {
        filteredProducts,
        productDetail,
        categories
    };
}

export default useDbImitation;
