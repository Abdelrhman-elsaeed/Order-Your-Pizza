# 🍕 Pizza Order System

A desktop application built with **C#** and **Windows Forms (.NET)** that simulates a Pizza Ordering kiosk. The application allows users to customize their pizza, calculates the total price dynamically in real-time, and manages the order workflow.

## 🚀 Features

* **Dynamic Price Calculation:** The total price updates automatically as soon as the user selects any option (Size, Crust, Toppings).
* **Order Summary:** A real-time display of the selected toppings, crust type, and dining preference.
* **Customization Options:**
    * **Size:** Small, Medium, Large.
    * **Crust:** Thin, Thick.
    * **Toppings:** Cheese, Olives, Mushrooms, Tomatoes, Green Peppers, Onions.
    * **Dining:** Eat In, Take Out.
* **Order Confirmation:** confirms the final price via a MessageBox and disables the form controls to prevent changes after ordering.
* **Reset Functionality:** One-click reset button to start a new order with default values.

## 🛠️ Technologies & Concepts Used

* **C#** (Backend Logic)
* **Windows Forms** (GUI)
* **Event-Driven Programming:** heavy use of `CheckedChanged` events to trigger real-time updates.
* **Tag Property Usage:** The logic efficiently uses the control's `Tag` property to store pricing data, making price adjustments easy without changing the code logic.
* **Input Validation:** Ensuring mutually exclusive options (Radio Buttons) and multiple choices (Checkboxes) are handled correctly.

## 📸 Screenshots

![_-ezgif com-video-to-gif-converter (2)](https://github.com/user-attachments/assets/4dc95a6c-297b-4be5-8f72-ab0b1c4c159c)


## 💻 How It Works

1.  **Selection:** The user interacts with Radio Buttons and Checkboxes.
2.  **Calculation:** The `UpdateTotalPrice()` method is called upon any event. It aggregates costs by converting the `Tag` values of checked items to floats.
3.  **Display:** The summary labels (`lbToppings`, `lbTotalPrice`, etc.) are updated instantly.
4.  **Checkout:** Clicking "Order Pizza" locks the interface until the "Reset Form" button is clicked.

## 🔧 Setup & Run

1.  Clone this repository:
    ```bash
    git clone [https://github.com/YourUsername/Pizza-Order-System.git](https://github.com/YourUsername/Pizza-Order-System.git)
    ```
2.  Open the solution file (`.sln`) in **Visual Studio**.
3.  Ensure you have the **.NET Framework** installed.
4.  Build and Run the project (`F5`).
