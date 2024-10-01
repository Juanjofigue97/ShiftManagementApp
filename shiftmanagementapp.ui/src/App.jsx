import React, { useState, useEffect } from 'react';

import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'

function App() {
    const [persons, setPersons] = useState([]);
    const [error, setError] = useState(null);

    useEffect(() => {
        const fetchPersons = async () => {
            try {
                const response = await fetch('http://localhost:5260/persons');
                if (!response.ok) {
                    throw new Error(`HTTP error! status: ${response.status}`);
                }
                const data = await response.json();
                setPersons(data);
            } catch (error) {
                console.error('Error fetching data: ', error);
                setError(error.message);
            }
        };

        fetchPersons();
    }, []);

    if (error) {
        return <div>Error: {error}</div>;
    }

    return (
        <div>
            <h1>Persons List</h1>
            <ul>
                {persons.map(person => (
                    <li key={person.id}>
                        {person.firstName} {person.lastName} - {person.email}
                    </li>
                ))}
            </ul>
        </div>
    );
}

export default App;
