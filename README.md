# ArtistWebsite
# This is the Final Project
# Done by :-
# Name: Satveer Kaur
# StudentID: 200476092

# Roles authentication and Authorization
This Website contains five tables which includes artists list, art collection, art courses, Supplies and list of upcoming events

Everyone can access Supplies, Art Courses and List of Events, and can also see list of artists and Collection of arts.
But only admin can create new artist, create new course, delete artists and courses.

For Example: In Artists Controller, I can view list of artists, but to create a new artist, role is authorized to be admin.
So, access is denied.


# Design View Screenshot of all five tables


![ArtCollection](https://user-images.githubusercontent.com/84339533/164203407-de17d3d7-b0ef-4751-92c4-a4e8108772cb.png)
![ArtCourses](https://user-images.githubusercontent.com/84339533/164203411-185ce0d1-a98a-4859-8d96-40bf9fc0cac7.png)
![Artists](https://user-images.githubusercontent.com/84339533/164203415-c8088c59-4818-488d-82c6-bf3fe1705990.png)
![Events](https://user-images.githubusercontent.com/84339533/164203418-96d37b6d-2bb0-4462-91d7-3aa26f2c7c00.png)
![Supplies](https://user-images.githubusercontent.com/84339533/164203448-636abcc3-09fc-4b35-bade-e78bd43ea710.png)


# Screenshots of Webpages
![Screenshot (393)](https://user-images.githubusercontent.com/84339533/164205281-9237dee4-1ed5-42aa-929d-f568d96ad223.png)
![Screenshot (394)](https://user-images.githubusercontent.com/84339533/164205284-8047d2de-c9c6-48d7-a2ed-5660ec8ea0b1.png)
![Screenshot (387)](https://user-images.githubusercontent.com/84339533/164205289-d23bb464-33e5-46ab-b0ce-b93775724cb4.png)
![Screenshot (388)](https://user-images.githubusercontent.com/84339533/164205290-e8fdf165-8b14-4757-b328-e968e1733ecb.png)
![Screenshot (389)](https://user-images.githubusercontent.com/84339533/164205291-cb56683b-e2a6-4e8f-a637-dddd68171f3e.png)
![Screenshot (390)](https://user-images.githubusercontent.com/84339533/164205295-8a24f655-37ba-4399-8732-701aabf13971.png)
![Screenshot (391)](https://user-images.githubusercontent.com/84339533/164205296-f8311c73-19cb-4051-b88a-5433556623f1.png)
![Screenshot (392)](https://user-images.githubusercontent.com/84339533/164205298-3ce1a4b9-cca5-4c8d-8566-2f8e4ef9af30.png)

# Role Management

 Create in Artist Controller can only be accessed by admin
 Create in ArtCollectionCOntroller can be accessed by both Admin and Artist
