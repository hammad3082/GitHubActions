# Tiny Python test example
def add(a, b):
    return a + b

def test_addition():
    result = add(2, 3)
    print("Python test running: 2 + 3 =", result)
    assert result == 5
