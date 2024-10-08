def main():
    # Define an empty list to store the input data
    data = []

    # Define a function to read input data
    def get_input_data():
        amount = int(input().strip())
        for i in range(amount):
            entry = input().strip()
            name, number = entry.split()
            data.append((name, int(number)))

    # Read input data and store it in the list
    get_input_data()

    # Sort the data in descending order based on the number
    data.sort(key=lambda x: x[1], reverse=True)

    # Print the top entry
    if data:
        top_entry = data[0]
        print(top_entry[0])
    else:
        print()

# Entry point for the script
if __name__ == "__main__":
    main()