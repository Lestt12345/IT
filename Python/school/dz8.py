class Instruction:
    def __init__(self, title):
        self.title = title

    def show(self):
        print(f"Instruction: {self.title}")

class FireInstruction(Instruction):
    def show(self):
        print(f"{self.title}: У разі пожежі залишайте приміщення спокійно та користуйтесь пожежними виходами.")

class ElectricInstruction(Instruction):
    def show(self):
        print(f"{self.title}: У разі ураження електричним струмом вимикайте електроживлення та не торкайтесь потерпілого голими руками.")

fire_instr = FireInstruction("Fire Safety Instruction")
electric_instr = ElectricInstruction("Electrical Safety Instruction")

fire_instr.show()
electric_instr.show()

# Це приклад поліморфізму,бо об'єкти різних класів (FireInstruction і ElectricInstruction) мають однаковий метод show(), але реалізують його по-своєму.