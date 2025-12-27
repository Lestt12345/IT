def safe_divide(a, b):
    try:
        return a / b
    except Exception as e:
        return e

print("--------------------------------------------") #у меня баги просто))
print(f"10 / 2 = {safe_divide(10, 2)}")
print(f"10 / 0 = {safe_divide(10, 0)}")
print(f"'10' / 2 = {safe_divide('10', 2)}")