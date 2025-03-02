MinovNightClub
is a simple Windows Forms application that simulates a nightclub experience, where users can deposit money, choose event dates, and place drink orders. The app is divided into three main sections:

To start it type this in cmd: git clone https://github.com/MinovS63/MinovNightClub.git


Main Form: Allows users to manage their balance.
Dates Form: Users can select events for Friday and Saturday.
Drinks Form: Users can purchase drinks based on their balance.
Features
Main Form
Balance Management:

Displays the current balance (BALANCE: Xlv).
Allows users to input deposits using a numeric keypad and deposit funds (up to 999lv).
Displays the balance after each deposit.
Includes error handling for invalid inputs.
Navigation:

Clicking the "Reserve" button leads users to the Dates form to select an event.
Dates Form
Event Selection:

Users can choose between Friday and Saturday events.
There are four buttons for different events, each leading to the Drinks form.
Navigation:

Users can return to the Main form from here.
Drinks Form
Drink Ordering:

Users can order drinks from a list, with prices ranging from 80lv to 650lv.
If the user's balance is sufficient, the order is processed, and the balance is updated.
If the user doesn't have enough funds, an error message is shown.
Navigation:

Users can return to the Main form after placing orders.
Files and Structure
Main.cs: Handles balance updates and navigation to the Dates form.
Dates.cs: Handles event selection and navigation to the Drinks form.
Drinks.cs: Handles drink orders and balance management.
Usage
Launch the application, and you will start at the Main Form.
Use the numeric buttons to deposit money into your account (up to 999lv).
Click the "Reserve" button to navigate to the Dates Form, where you can choose an event to attend.
After selecting an event, the app will navigate to the Drinks Form, where you can purchase drinks. Each drink has a specified cost.
If you have enough funds, your balance will be updated after each purchase. Otherwise, you'll be notified that there are insufficient funds.
Notes
Balance Limit: The maximum amount that can be deposited is 999lv.
Error Handling: If an invalid input is detected or there are insufficient funds, appropriate messages will be shown to the user.
