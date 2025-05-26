import tkinter as tk
from tkinter import ttk, messagebox, filedialog
from datetime import datetime
import os

class BudgetManager:
    def __init__(self, root):
        self.root = root
        self.root.title("Menedżer budżetu")
        self.root.geometry("1200x520")

        self.transactions = []
        self.current_file = None

        self.layout()

    def layout(self):
        add_frame = tk.Frame(self.root, pady=10)
        add_frame.pack()

        tk.Label(add_frame, text="Rodzaj transakcji: ").grid(row=0, column=0)
        self.type_var = tk.StringVar(value="Wydatek")
        ttk.Combobox(add_frame, textvariable=self.type_var, values=["Wydatek", "Przychód"], width=10, state="readonly").grid(row=0, column=1)

        tk.Label(add_frame, text="Kwota:").grid(row=0, column=2)
        self.amount_entry = tk.Entry(add_frame, width=15)
        self.amount_entry.grid(row=0, column=3)

        tk.Label(add_frame, text="Kategoria:").grid(row=1, column=0)
        self.category_var = tk.StringVar()
        ttk.Combobox(add_frame, textvariable=self.category_var, values=["Opłaty", "Jedzenie", "Transport", "Rozrywka", "Inne"], width=15).grid(row=1, column=1)

        tk.Label(add_frame, text="Opis:").grid(row=1, column=2)
        self.info_entry = tk.Entry(add_frame, width=25)
        self.info_entry.grid(row=1, column=3)

        self.add_button = tk.Button(add_frame, text="Dodaj", command=self.add)
        self.add_button.grid(row=2, column=0, columnspan=4, pady=10)

        self.tree = ttk.Treeview(self.root, columns=("Data", "Rodzaj", "Kwota", "Kategoria", "Opis"), show='headings', height=12)
        for i in self.tree["columns"]:
            self.tree.heading(i, text=i)
        self.tree.pack(pady=10)

        self.balance_label = tk.Label(self.root, text="Bilans: 0.00 zł", font=("Arial", 14))
        self.balance_label.pack()

        button_frame = tk.Frame(self.root, pady=5)
        button_frame.pack()

        self.save_button = tk.Button(button_frame, text="Zapisz", command=self.save)
        self.save_button.grid(row=0, column=0, padx=5)

        self.load_button = tk.Button(button_frame, text="Wczytaj", command=self.load)
        self.load_button.grid(row=0, column=1, padx=5)

        self.delete_button = tk.Button(button_frame, text="Usuń", command=self.delete)
        self.delete_button.grid(row=0, column=2, padx=5)

    def add(self):
        try:
            amount = float(self.amount_entry.get())
        except ValueError:
            messagebox.showerror("Błąd", "Kwota musi być liczbą.")
            return

        type = self.type_var.get()
        category = self.category_var.get() or "Inne"
        info = self.info_entry.get().strip()
        date = datetime.now().strftime("%Y-%m-%d %H:%M")

        if type == "Wydatek":
            amount = -abs(amount)
        else:
            amount = abs(amount)

        transaction = {
            "date": date,
            "type": "Przychód" if amount > 0 else "Wydatek",
            "amount": amount,
            "category": category,
            "info": info
        }

        self.transactions.append(transaction)
        self.refresh()
        self.clear()

    def refresh(self):
        for i in self.tree.get_children():
            self.tree.delete(i)

        for i, j in enumerate(self.transactions):
            self.tree.insert("", tk.END, iid=str(i), values=(
                j["date"], j["type"], f"{j['amount']:.2f} zł", j["category"], j["info"]
            ))

        total = sum(i["amount"] for i in self.transactions)
        self.balance_label.config(text=f"Bilans: {total:.2f} zł")

    def delete(self):
        selected = self.tree.selection()
        if not selected:
            messagebox.showwarning("Brak zaznaczenia", "Zaznacz operację do usunięcia.")
            return

        index = int(selected[0])
        del self.transactions[index]
        self.refresh()

    def clear(self):
        self.amount_entry.delete(0, tk.END)
        self.info_entry.delete(0, tk.END)
        self.category_var.set("")
        self.type_var.set("Wydatek")

    def save(self):
        if not self.current_file:
            messagebox.showwarning("Brak pliku", "Najpierw wczytaj plik, do którego chcesz zapisać.")
            return

        try:
            with open(self.current_file, "w", encoding="utf-8") as f:
                for i in self.transactions:
                    line = f"{i['date']}\t{i['type']}\t{i['amount']:.2f} zł\t{i['category']}\t{i['info']}\n"
                    f.write(line)
            messagebox.showinfo("Zapisano", f"Dane zapisane do:\n{self.current_file}")
        except Exception as e:
            messagebox.showerror("Błąd zapisu", str(e))

    def load(self):
        file_path = filedialog.askopenfilename(
            defaultextension=".txt",
            filetypes=[("Pliki tekstowe", "*.txt")],
            title="Wybierz plik"
        )
        if not file_path:
            return

        try:
            self.transactions.clear()
            with open(file_path, "r", encoding="utf-8") as f:
                for i in f:
                    lane = i.strip().split("\t")
                    if len(lane) == 5:
                        date, type, amount, category, info = lane
                        amount = float(amount.replace(" zł", "").replace(",", "."))
                        self.transactions.append({
                            "date": date,
                            "type": type,
                            "amount": amount,
                            "category": category,
                            "info": info
                        })
            self.current_file = file_path
            self.refresh()
            messagebox.showinfo("Wczytano", f"Wczytano dane z:\n{file_path}")
        except Exception as e:
            messagebox.showerror("Błąd odczytu", str(e))

if __name__ == "__main__":
    root = tk.Tk()
    app = BudgetManager(root)
    root.mainloop()


