import zipfile
import os
import tkinter as tk
from tkinter import filedialog, messagebox

def create_zip(archive_name, files):
    with zipfile.ZipFile(archive_name, 'w') as archive:
        for file in files:
            if os.path.exists(file):
                archive.write(file, os.path.basename(file))

def extract_zip(archive_name, extract_to):
    with zipfile.ZipFile(archive_name, 'r') as archive:
        archive.extractall(extract_to)

def select_files():
    return filedialog.askopenfilenames(title="Select Files")

def select_archive():
    return filedialog.askopenfilename(title="Select Archive", filetypes=[("ZIP files", "*.zip")])

def select_directory():
    return filedialog.askdirectory(title="Select Directory")

def create_archive_ui():
    files = select_files()
    if not files:
        return

    archive_name = filedialog.asksaveasfilename(title="Save Archive As", defaultextension=".zip", filetypes=[("ZIP files", "*.zip")])
    if not archive_name:
        return

    create_zip(archive_name, files)
    messagebox.showinfo("Success", f"Archive {archive_name} created successfully.")

def extract_archive_ui():
    archive_name = select_archive()
    if not archive_name:
        return

    extract_to = select_directory()
    if not extract_to:
        return

    extract_zip(archive_name, extract_to)
    messagebox.showinfo("Success", f"Archive {archive_name} extracted to {extract_to}.")

def main():
    root = tk.Tk()
    root.title("Python Archiver")

    create_btn = tk.Button(root, text="Create Archive", command=create_archive_ui)
    create_btn.pack(pady=10)

    extract_btn = tk.Button(root, text="Extract Archive", command=extract_archive_ui)
    extract_btn.pack(pady=10)

    root.mainloop()

if __name__ == "__main__":
    main()
