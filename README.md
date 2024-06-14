# Contacts Manager

The Contacts Manager is a straightforward yet robust application designed for managing a list of contacts.
It offers essential functionalities like adding new contacts, removing existing ones, and viewing all stored contacts.
The primary implementation resides in the `CManager` class within the `Contacts_Manager` namespace, providing methods 
to add, remove, and view contacts. A key feature of the application is its prevention of duplicate contacts by 
ensuring that a contact with an existing name cannot be added again, thereby maintaining the uniqueness of entries.

The project also incorporates a comprehensive suite of unit tests under the `Contacts_Manager_Test` namespace.
These tests rigorously verify the functionality of the `CManager` class. They validate that adding a new contact 
increases the list size, attempting to add a duplicate contact does not alter the list, removing a contact decreases
the list size appropriately, and viewing contacts retrieves the expected number of entries.

This structured approach ensures the reliability and correctness of the Contacts Manager application,
making it suitable for handling basic contact management tasks efficiently.
o includes a comprehensive set of unit tests under the Contacts_Manager_Test namespace.
These tests validate the functionality of the CManager class, ensuring that adding, removing, and viewing contacts
work as expected. For instance, the tests check that adding a new contact increases the list size, 
attempting to add a duplicate contact does not alter the list, removing a contact decreases the list size, 
and viewing contacts retrieves the correct number of entries.