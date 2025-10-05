import tkinter as tk

def move_text():
    # Получаем текст из начала исходного текста
    current_text = text.get(1.0, tk.END)
    
    # Удаляем первый символ из текста и вставляем обновленный текст
    text.delete(1.0, tk.END)
    text.insert(tk.END, current_text[1:])

root = tk.Tk()

# Используем Text вместо Label
text = tk.Text(root, wrap=tk.WORD, height=1, font=("Arial", 14))
text.insert(tk.END, "Фиксированная часть. Перемещаемая часть.")
text.pack(padx=10, pady=10)

button = tk.Button(root, text="Переместить текст", command=move_text)
button.pack(pady=10)

root.mainloop()