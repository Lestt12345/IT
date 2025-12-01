# 1. Б)
# 2. А), В), Д)
# 3. Б)
# 4. В)
# 5. А)
# 6. Г)
# 7. А), Б), В), Г)
# 8. 5 → 1 → 4 → 3 → 2
# 9. В), Ґ), Д)
# 10. класу
# 11. В)
# 12. А)
# 13. А), Б), В)
# 14. 
#   1 — В)
#   2 — Ґ)
#   3 — А)
#   4 — Б)
# 15. __init__
# 16. базовий, похідний
# 17. Г)
# 18. наслідування

import math

class Circle:
    def __init__(self, radius):
        self.radius = radius

    def get_area(self):
        return math.pi * self.radius * self.radius

    def get_circumference(self):
        return 2 * math.pi * self.radius

    def set_radius(self, radius):
        self.radius = radius

circle = Circle(5)
print("Area:", circle.get_area())
print("Circumference:", circle.get_circumference())

circle.set_radius(10)
print("New area:", circle.get_area())
print("New circumference:", circle.get_circumference())
