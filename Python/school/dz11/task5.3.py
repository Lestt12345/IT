import tkinter as tk
from tkinter import ttk, messagebox

class BMICalculator:
    def __init__(self, root):
        self.root = root
        self.setup_ui()
        
    def setup_ui(self):
        self.root.title("BMI Calculator")
        self.root.resizable(False, False)
        
        # Main frame
        main_frame = ttk.Frame(self.root, padding="20")
        main_frame.grid(row=0, column=0, sticky="nsew")
        
        # Weight input
        ttk.Label(main_frame, text="Weight (kg):").grid(row=0, column=0, padx=5, pady=5, sticky="w")
        self.weight_var = tk.StringVar()
        weight_entry = ttk.Entry(main_frame, textvariable=self.weight_var, width=10)
        weight_entry.grid(row=0, column=1, padx=5, pady=5, sticky="w")
        weight_entry.focus()
        
        # Height input
        ttk.Label(main_frame, text="Height (cm):").grid(row=1, column=0, padx=5, pady=5, sticky="w")
        self.height_var = tk.StringVar()
        height_entry = ttk.Entry(main_frame, textvariable=self.height_var, width=10)
        height_entry.grid(row=1, column=1, padx=5, pady=5, sticky="w")
        
        # Calculate button
        ttk.Button(
            main_frame,
            text="Calculate BMI",
            command=self.calculate_bmi
        ).grid(row=2, column=0, columnspan=2, pady=15, sticky="ew")
        
        # Result display
        self.result_var = tk.StringVar(value="Enter your details")
        ttk.Label(
            main_frame,
            textvariable=self.result_var,
            font=('Arial', 10, 'bold'),
            foreground='#0066cc',
            justify='center'
        ).grid(row=3, column=0, columnspan=2, pady=5)
        
        # BMI Categories
        ttk.Label(
            main_frame,
            justify='left'
        ).grid(row=4, column=0, columnspan=2, pady=10, sticky="w")
        
        # Bind Enter key
        self.root.bind('<Return>', lambda e: self.calculate_bmi())
    
    def calculate_bmi(self, event=None):
        try:
            # Get and validate weight
            weight = float(self.weight_var.get().replace(',', '.'))
            if weight <= 0:
                raise ValueError("Weight must be positive")
                
            # Get and validate height
            height = float(self.height_var.get().replace(',', '.'))
            if height <= 0:
                raise ValueError("Height must be positive")
                
            # Convert height from cm to meters
            height_m = height / 100
            
            # Calculate BMI
            bmi = weight / (height_m ** 2)
            
            # Determine category
            if bmi < 18.5:
                color = "#3498db"  # Blue
            elif bmi < 25:
                color = "#2ecc71"  # Green
            elif bmi < 30:
                color = "#f39c12"  # Orange
            else:
                color = "#e74c3c"  # Red
                
            # Update result
            result_text = f"Your BMI: {bmi:.1f}"
            self.result_var.set(result_text)
            self.result_var.configure(foreground=color)
            
        except ValueError as e:
            messagebox.showerror("Input Error", "Please enter valid positive numbers")

if __name__ == "__main__":
    root = tk.Tk()
    app = BMICalculator(root)
    root.mainloop()