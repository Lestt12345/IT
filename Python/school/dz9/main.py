from geometry import Circle, Triangle

circle = Circle(5)
triangle = Triangle(10, 6)

print("Circle area:", round(circle.area(), 2))
print("Triangle area:", round(triangle.area(), 2))

figures = [
    Circle(3),
    Triangle(4, 5),
    Circle(2)
]

total_area = sum(round(f.area(), 2) for f in figures)
print("Total area:", total_area)
