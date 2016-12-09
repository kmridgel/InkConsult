# InkConsult
Final Project for Software Engineering
Documentation for InkConsult
Kiersten Ridgel, Sean Gerving, Jeff Ross
December 2016
Legalities
	The purpose of the InkConsult Application(hereafter referred to as Inkconsult) is designed only for the use of Fossil Tattoo in Fruita, CO., its managers and relevant employees. It has not been modified to accommodate any other party or service.
	InkConsult was designed, coded and implemented by Kiersten Ridgel, Sean Gerving and Jeff Ross, senior computer science students of Colorado Mesa University. It is not a professionally designed application and therefore may be flawed at the time of acquirement by Fossil Tattoo. The students are not responsible for any changes made to InkConsult, past December 16, 2016, although they reserve the privilege to copy and show the code and pages of InkConsult as completed on December 16, 2016, for the purposes of resume portfolio material. The application itself is the intellectual property of Kiersten Ridgel, Sean Gerving and Jeff Ross.
This document was written as a user guide, and is not a repair manual. Any repairs necessary to the functionality of the application should be referred to any of the above mentioned students or to another computer professional with the understanding that any changes made are not the responsibility of the aforementioned students.
I hereby certify that this application is completed and functional, to the best of my ability, so that it may be used forthwith for Fossil Tattoo first tattoo consultations.


Kiersten Ridgel									Date


Sean Gerving                                                                                                                        Date


Jeff Ross                                                                                                                                 Date

Overview
	The InkConsult application is designed to replace the first tattoo consultation questions and appointment setting time that is normally complete by the client together with the chosen artist. It removes the need for the artist to walk away from any current work or sanitary area, and allows the client to complete a short questionnaire that will give the artist all of the information they need to know about the client and potential artwork. Its user-friendly design allow any client, no matter their computer experience, to complete the questions and appointment setting with ease. There are two sides to the application; the artist’s calendar management side, and the client interface. This document will explain and walk through both.
Installing InkConsult
	InkConsult is a file package that can be easily moved from storage to machine and back. To install, simply plug in the USB flash drive containing InkConsult and open the location in a file explorer. (Modern Windows machines will prompt for “What do you want to do with…?” where “Open Folder to view Files” is an option. Click this). Once the USB file is open on the computer, simply click the InkConsult file folder and drag to the computer desktop. Once done, open the InkConsult folder in the file explorer and locate the file labeled “appointment”. Click this folder and drag to the computer’s C:/ drive. Close the USB file explorer. 
Running InkConsult
	Once the files have been installed on the computer, open the file labeled InkConsult on the computer’s desktop. Inside is a file named “InkConsult.exe”. This is the program itself. Double-click on this file and InkConsult will start.





Start Page
	Once the application has been started, the Start Page will appear. This includes the Fossil Tattoo logo and Start Button. From here, both the artist interface and the client interface can be accessed.
 

Artist Interface
	Clicking on the Fossil Tattoo Logo will create a pop up asking for the artist’s login information. Default information is username: artist’s first name, password: artist’s last name. This can be changed later. If the artist’s login is accidentally triggered by a client, there is a Close Button that will take them back to the start page. 
	 
	Artist Calendar
		A successful login will show the artist calendar on the following page. It displays all known appointments on that artist’s (the one who logged in) calendar in that month, with options to navigate to different months. An Exit Button at the bottom of the age will take the user back to the Start Page.
  
Clicking on a day will the “Delete Appointment” page, populated with all the artist’s appointments for that day. 
	Delete Appointment
	The Delete Appointment page will show all information for all appointments for that artist on any given day, including all pertinent information entered at the time that the appointment was made. Under each appointment is an option to delete that appointment. This will erase the appointment and its information from the calendar, but will not delete the information file made when the appointment was scheduled (must be done manually in a file explorer). At the bottom of the screen is the Close Button, which will take the user back to the calendar page. 
 








Client Interface
	Back on the Start Page, the Client Interface is again accessible. Simply Click the Start Button to begin the client interface.
The Client Information Questionnaire
	The first page of the client interface is a questionnaire for all personal contact information and pertinent demographic information. All fields must be completed in order to continue. Failure to fill out a necessary field and clicking the Continue Button will cause the necessary fields to change color to yellow or red. Upon successful completion of the form, the Continue Button will take the user to the next questionnaire page. The Go Back Button will take the user back to the Start Page, and Clear Form Button will erase any information that has already been entered. 
 
	The Tattoo Information Questionnaire
	The next page is the questionnaire with questions pertaining to the tattoo the client wants to have done. Each answered question will cause the next question to appear. All questions must be answered before proceeding. As will the previous page, the Continue Button will take the user to the next page, and the Go Back Button will take the user to the previous page (Client Information Questionnaire).
 


	The Pain Map
	 
	The Pain map is an interactive page that will display the relative pain associated with tattooing specific areas of the body. Four levels of pain are associated with the map: Red-1, Orange-2, Yellow-3, Green-4, and Blue-5. Each level also has a depiction of a face (or nuclear blast cloud, in the case of Red) associated with pain level. Clicking each area of the body will cause it to be selected and the text description of the area will appear in the box in the middle of the page as an area to be tattooed. Users can choose up to five areas to be tattooed for one appointment. Clicking on the text description of an area in the box and clicking the “Undo” button next to the box will remove the selected area from the list to be tattooed. The original map is black; rolling over an area with the mouse will cause it to fill in with the color associated to the pain level. Selected areas will stay that color. Clicking the Show All Areas Button will fill in the map with all colors, as shown below. 
As with the previous pages, clicking the Continue Button will take the user to the next page. Clicking the Go Back Button will take the user to the previous page (Tattoo Information Questionnaire).
 
	







Select Artist Page
	The Select Artist page is populated with profile pictures and names of the three current artists working at Fossil Tattoo. Clicking on an artist will cause them to be highlighted and will select them as the artist the client wishes to work with. As with the previous pages, clicking the Continue Button will take the user to the next page, and clicking the Go Back Button will take the user to the previous page(Pain Map).
 


	The Calendar
	The Calendar page shows the current month’s calendar for the artist that was selected on the previous page, including times that have been previously reserved for appointments. Clicking on a day on the calendar will display the Appointment Setter. Clicking the month buttons on either side of the bottom of the page will take the user to that month’s calendar and display it in a similar fashion. 
 


	The Appointment Setter Page
	The Appointment Setter will allow the user to choose hour segments, beginning with the time that they wish the appointment to start, on the day chosen in the previous page’s calendar. The times that have been previously reserved by other clients is grayed out and says, “This time slot is reserved.” These times are not available to click on and no new appointments may be schedule for these times. 
 

End Result
	Once an appointment has been set, the calendar will update witht eh new appointment. All information gathered through InkConsult will be sent to a premade file folder within the InkConsult file as a text file for further use, which can be accessed at any time. 


A Note From the Programmers
	We have spent the better part of four months working on this project and proudly present it to you as our finest work acheiveable during the course of our Software Engineering capstone class. Thank you for your interest in our work and project. Happy inking!

Sincerely,
Kiersten Ridgel
Sean Gerving
Jeff Ross
