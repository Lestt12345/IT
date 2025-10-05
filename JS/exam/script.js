// CONTAINERS
const booksContainer = document.querySelector("#books");
const visitorsContainer = document.querySelector("#visitors");
const cardsContainer = document.querySelector("#cards");
const statisticsContainer = document.querySelector("#statistics");
// CONTAINERS

// NAV FUNCTIONAL
const navSwitchs = document.querySelectorAll("nav ul li");
const containers = [booksContainer, visitorsContainer, cardsContainer, statisticsContainer];

containers.forEach((container) => {
    container.style.display = "none";
});

containers[0].style.display = "block";
navSwitchs[0].style.background = "#178b965b";

navSwitchs.forEach((navSwitch, index) => {
    navSwitch.addEventListener("click", () => {
        navSwitchs.forEach((navSwitch) => {
            navSwitch.style.background = "none";
        });
        navSwitch.style.background = "#178b965b";
        containers.forEach((container, i) => {
            container.style.display = i === index ? "block" : "none";
        });
    });
});
// NAV FUNCTIONAL

// MODALS
const addBookModal = document.querySelector("#addBookModal");
const editBookModal = document.querySelector("#editBookModal");
const addVisitorModal = document.querySelector("#addVisitorModal");
const editVisitorModal = document.querySelector("#editVisitorModal");
const addCardModal = document.querySelector("#addCardModal");

addBookModal.style.display = "none";
editBookModal.style.display = "none";
addVisitorModal.style.display = "none";
editVisitorModal.style.display = "none";
addCardModal.style.display = "none";
// MODALS

// GET / SET DATA
// example of data
// data = {
//     books: [],
//     visitors: [],
//     cards: []
// }
// example of data

function setData(data) {
    localStorage.setItem("data", JSON.stringify(data));
}

function getData() {
    const data = localStorage.getItem("data");
    if (!data) {
        const emptyData = { books: [], visitors: [], cards: [] };
        setData(emptyData);
        return emptyData;
    }
    return JSON.parse(data);
}
// GET / SET DATA

// LOAD BOOKS / VISITORS / CARS / STATISTICS
const data = getData();
const booksTable = document.querySelector("#books tbody");
const visitorsTable = document.querySelector("#visitors tbody");
const cardsTable = document.querySelector("#cards tbody");
const statisticsTable = document.querySelector("#statistics tbody");
booksTable.innerHTML = "";
if (data.books.length === 0) {
    booksTable.innerHTML = `<tr>No books</tr>`;
} else {
    data.books.forEach((book) => {
        const row = document.createElement("tr");
        row.innerHTML = `
            <td>${book.id}</td>
            <td>${book.name}</td>
            <td>${book.author}</td>
            <td>${book.year}</td>
            <td>${book.publisher}</td>
            <td>${book.countOfPages}</td>
            <td>${book.countOnLibrary}</td>
            <td><div class="bookEdit"><div class="editBtn"><img src="img/edit.png" alt=""></div></div></td>
            <td><div class="deleteBtn"><img src="img/delete.png" alt=""></div></td>
        `;
        booksTable.appendChild(row);
    });
}

visitorsTable.innerHTML = "";
if (data.visitors.length === 0) {
    visitorsTable.innerHTML = `<tr>No visitors</tr>`;
} else {
    data.visitors.forEach((visitor) => {
        const row = document.createElement("tr");
        row.innerHTML = `
            <td>${visitor.id}</td>
            <td>${visitor.name}</td>
            <td>${visitor.phone}</td>
            <td><div class="editBtn"><img src="img/edit.png" alt=""></div></td>
        `;
        visitorsTable.appendChild(row);
    });
}

cardsTable.innerHTML = "";
if (data.cards.length === 0) {
    cardsTable.innerHTML = `<tr>No cards</tr>`;
} else {
    data.cards.forEach((card) => {
        const row = document.createElement("tr");
        row.innerHTML = `
            <td>${card.id}</td>
            <td>${card.visitorId}</td>
            <td>${card.bookId}</td>
            <td>${card.issueDate}</td>
            <td>${card.returnDate}</td>
            <td><button>Take back</button></td>
        `;
        cardsTable.appendChild(row);
    });
}
function renderStatistics(data) {
    const popularBooks = data.cards.reduce((acc, curr) => {
        const foundBook = acc.find(book => book.bookId === curr.bookId);
        if (foundBook) {
            foundBook.count++;
        } else {
            acc.push({ bookId: curr.bookId, count: 1 });
        }
        return acc;
    }, []).sort((a, b) => b.count - a.count).slice(0, 5);

    const popularVisitors = data.cards.reduce((acc, curr) => {
        const foundVisitor = acc.find(visitor => visitor.visitorId === curr.visitorId);
        if (foundVisitor) {
            foundVisitor.count++;
        } else {
            acc.push({ visitorId: curr.visitorId, count: 1 });
        }
        return acc;
    }, []).sort((a, b) => b.count - a.count).slice(0, 5);

    const popularBooksOl = document.querySelector("#statistics .topList:nth-child(1) ol");
    const popularVisitorsOl = document.querySelector("#statistics .topList:nth-child(2) ol");

    popularBooksOl.innerHTML = "";
    popularVisitorsOl.innerHTML = "";

    popularBooks.forEach(book => {
        const li = document.createElement("li");
        li.innerHTML = `${data.books.find(b => b.id === book.bookId).name}: ${book.count}`;
        popularBooksOl.appendChild(li);
    });

    popularVisitors.forEach(visitor => {
        const li = document.createElement("li");
        li.innerHTML = `${data.visitors.find(v => v.id === visitor.visitorId).name}: ${visitor.count}`;
        popularVisitorsOl.appendChild(li);
    });
}
renderStatistics(data);
// LOAD BOOKS / VISITORS / CARS / STATISTICS

// MODALS OPEN FUNCTIONAL
const addBookBtn = document.querySelector("#addBookBtn");
const addVisitorBtn = document.querySelector("#addVisitorBtn");
const addCardBtn = document.querySelector("#addCardBtn");;
addBookBtn.addEventListener("click", () => {
    addBookModal.style.display = "flex";
});
addVisitorBtn.addEventListener("click", () => {
    addVisitorModal.style.display = "flex";
})
addCardBtn.addEventListener("click", () => {
    addCardModal.style.display = "flex";
})
function openModals() {
    const booksTr = document.querySelectorAll("#books tbody tr");
    const visitorsTr = document.querySelectorAll("#visitors tbody tr");
    const cardsTr = document.querySelectorAll("#cards tbody tr")
    const editBookIdLabel = document.querySelector("#editBookIdLabel");
    editBookIdLabel.disabled = true;
    editBookIdLabel.style.background = "#c7c7c7ff";
    if (booksTr) {
        booksTr.forEach((bookTr) => {
            const editBookBtn = bookTr.querySelector(".editBtn");
            if (editBookBtn) {
                editBookBtn.addEventListener("click", () => {
                    editBookModal.style.display = "flex";
                    editBookIdLabel.value = bookTr.querySelectorAll("td")[0].innerHTML;
                    const editBookForm1 = document.querySelector("#editBookModal form");
                    const bookNameInput = editBookForm1.querySelector("input[id='bookName']");
                    const authorInput = editBookForm1.querySelector("input[id='author']");
                    const yearInput = editBookForm1.querySelector("input[id='year']");
                    const publisherInput = editBookForm1.querySelector("input[id='publisher']");
                    const countOfPagesInput = editBookForm1.querySelector("input[id='countOfPages']");
                    const countOnLibraryInput = editBookForm1.querySelector("input[id='countOnLibrary']");
                    let data = getData();
                    bookNameInput.value = data.books.find(b => b.id === Number(editBookIdLabel.value)).name;
                    authorInput.value = data.books.find(b => b.id === Number(editBookIdLabel.value)).author;
                    yearInput.value = data.books.find(b => b.id === Number(editBookIdLabel.value)).year;
                    publisherInput.value = data.books.find(b => b.id === Number(editBookIdLabel.value)).publisher;
                    countOfPagesInput.value = data.books.find(b => b.id === Number(editBookIdLabel.value)).countOfPages;
                    countOnLibraryInput.value = data.books.find(b => b.id === Number(editBookIdLabel.value)).countOnLibrary;
                });
            }
            const deleteBookBtn = bookTr.querySelector(".deleteBtn");
            if (deleteBookBtn) {
                deleteBookBtn.addEventListener("click", () => {
                    deleteBookFunc(bookTr.querySelectorAll("td")[0].innerHTML);
                });
            }
        });
    }
    const editVisitorIdLabel = document.querySelector("#editVisitorIdLabel");
    editVisitorIdLabel.disabled = true;
    editVisitorIdLabel.style.background = "#c7c7c7ff";
    if (visitorsTr) {
        visitorsTr.forEach((visitorTr) => {
            const editVisitorBtn = visitorTr.querySelector(".editBtn");
            if (editVisitorBtn) {
                editVisitorBtn.addEventListener("click", () => {
                    editVisitorIdLabel.value = visitorTr.querySelectorAll("td")[0].innerHTML;
                    const editVisitorForm1 = document.querySelector("#editVisitorModal form");
                    const nameInput = editVisitorForm1.querySelector("input[id='visitorName']");
                    const phoneInput = editVisitorForm1.querySelector("input[id='phone']");
                    let data = getData();
                    nameInput.value = data.visitors.find(v => v.id === Number(editVisitorIdLabel.value)).name;
                    phoneInput.value = data.visitors.find(v => v.id === Number(editVisitorIdLabel.value)).phone;
                    editVisitorModal.style.display = "flex";
                });
            }
            const deleteVisitorBtn = visitorTr.querySelector(".deleteBtn");
            if (deleteVisitorBtn) {
                deleteVisitorBtn.addEventListener("click", () => {
                    deleteVisitorFunc(visitorTr.querySelectorAll("td")[0].innerHTML);
                });
            }
        });
    }
    if (cardsTr) {
        cardsTr.forEach((cardTr) => {
            const deleteCardBtn = cardTr.querySelector("button");
            if (deleteCardBtn) {
                deleteCardBtn.addEventListener("click", () => {
                    deleteCardFunc(cardTr.querySelectorAll("td")[0].innerHTML);
                });
            }
        });
    }
}
openModals();
// MODALS OPEN FUNCTIONAL

// MODALS CLOSE FUNCTIONAL
const modalCloseBtns = document.querySelectorAll(".modalCloseBtn");
if (modalCloseBtns) {
    modalCloseBtns.forEach((modalCloseBtn) => {
        modalCloseBtn.addEventListener("click", () => {
            const modal = modalCloseBtn.parentNode.parentNode;
            modal.style.display = "none";
        });
    });
}
// MODALS CLOSE FUNCTIONAL

// VALIDATION
function validatePositiveNumber(value) {
    return !isNaN(value) && Number(value) >= 0;
}

document.querySelectorAll("form").forEach(form => {
    form.addEventListener("submit", (e) => {
        const inputs = form.querySelectorAll("input");
        for (let input of inputs) {
            if (input.hasAttribute("required") && !input.value.trim()) {
                alert("All fields are required!");
                e.preventDefault();
                return;
            }
            if (input.type === "number" && !validatePositiveNumber(input.value)) {
                alert("Numeric fields must be >= 0");
                e.preventDefault();
                return;
            }
        }
    });
});
// VALIDATION

// ADD / EDIT / DELETE BOOKS
const addBookForm = document.querySelector("#addBookModal form");
addBookForm.addEventListener("submit", (e) => {
    e.preventDefault();
    const bookName = addBookForm.querySelector("#bookName").value;
    const author = addBookForm.querySelector("#author").value;
    const year = addBookForm.querySelector("#year").value;
    const publisher = addBookForm.querySelector("#publisher").value;
    const countOfPages = addBookForm.querySelector("#countOfPages").value;
    const countOnLibrary = addBookForm.querySelector("#countOnLibrary").value;
    const data = getData();
    let id = 1;
    while (data.books.some((book) => book.id === id)) {
        id++;
    }
    const book = {
        id: id,
        name: bookName,
        author: author,
        year: year,
        publisher: publisher,
        countOfPages: countOfPages,
        countOnLibrary: countOnLibrary
    };
    data.books.push(book);
    setData(data);
    addBookModal.style.display = "none";
    renderBooks(data.books);
})
const editBookForm = document.querySelector("#editBookModal form");
editBookForm.addEventListener("submit", (e) => {
    e.preventDefault();
    const bookName = editBookForm.querySelector("#bookName").value;
    const author = editBookForm.querySelector("#author").value;
    const year = editBookForm.querySelector("#year").value;
    const publisher = editBookForm.querySelector("#publisher").value;
    const countOfPages = editBookForm.querySelector("#countOfPages").value;
    const countOnLibrary = editBookForm.querySelector("#countOnLibrary").value;
    const id = editBookForm.querySelector("#editBookIdLabel").value;
    const book = {
        id: id,
        name: bookName,
        author: author,
        year: year,
        publisher: publisher,
        countOfPages: countOfPages,
        countOnLibrary: countOnLibrary
    };
    const data = getData();
    data.books[data.books.findIndex(b => b.id === Number(id))] = book;
    setData(data);
    editBookModal.style.display = "none";
    renderBooks(data.books);
})
function deleteBookFunc(id) {
    const data = getData();
    data.books = data.books.filter(book => book.id.toString() !== id);
    setData(data);
    renderBooks(data.books);
}
// ADD / EDIT / DELETE BOOKS

// ADD / EDIT / DELETE VISITORS
const addVisitorForm = document.querySelector("#addVisitorModal form");
addVisitorForm.addEventListener("submit", (e) => {
    e.preventDefault();
    const visitorName = addVisitorForm.querySelector("#visitorName").value;
    const visitorPhone = addVisitorForm.querySelector("#phone").value;
    const data = getData();
    let id = 1;
    while (data.visitors.some((visitor) => visitor.id === id)) {
        id++;
    }
    const visitor = {
        id: id,
        name: visitorName,
        phone: visitorPhone
    };
    data.visitors.push(visitor);
    setData(data);
    addVisitorModal.style.display = "none";
    renderVisitors(data.visitors);
})
const editVisitorForm = document.querySelector("#editVisitorModal form");
editVisitorForm.addEventListener("submit", (e) => {
    e.preventDefault();
    const visitorName = editVisitorForm.querySelector("#visitorName").value;
    const visitorPhone = editVisitorForm.querySelector("#phone").value;
    const visitor = {
        id: editVisitorIdLabel.value,
        name: visitorName,
        phone: visitorPhone
    };
    const data = getData();
    data.visitors[data.visitors.findIndex(v => v.id === Number(editVisitorIdLabel.value))] = visitor;
    setData(data);
    editVisitorModal.style.display = "none";
    renderVisitors(data.visitors);
})
function deleteVisitorFunc(id) {
    const data = getData();
    data.visitors = data.visitors.filter(visitor => visitor.id.toString() !== id);
    setData(data);
    renderBooks(data.visitors);
}
// ADD / EDIT / DELETE VISITORS

// ADD / DELETE CARDS
const addCardForm = document.querySelector("#addCardModal form");
addCardForm.addEventListener("submit", (e) => {
    e.preventDefault();
    const visitorId = Number(addCardForm.querySelector("#visitorId").value);
    const bookId = Number(addCardForm.querySelector("#bookId").value);
    const issueDate = addCardForm.querySelector("#issueDate").value;
    const returnDate = addCardForm.querySelector("#returnDate").value || null;

    const data = getData();
    const book = data.books.find(b => b.id === bookId);
    if (!book) {
        alert("Book not found");
        return;
    }
    if (book.countOnLibrary <= 0) {
        alert("No copies available");
        return;
    }
    book.countOnLibrary = Number(book.countOnLibrary) - 1;

    let id = 1;
    while (data.cards.some((card) => card.id === id)) id++;

    const card = { id, visitorId, bookId, issueDate, returnDate };
    data.cards.push(card);
    setData(data);
    addCardModal.style.display = "none";
    renderCards(data.cards);
    renderStatistics(data);
});
function deleteCardFunc(id) {
    const data = getData();
    id = Number(id);
    data.books.find((book) => book.id === data.cards.find((card) => card.id === id).bookId).countOnLibrary++;
    data.cards = data.cards.filter((card) => card.id !== id);
    setData(data);
    renderCards(data.cards);
    renderStatistics(data);
}
// ADD / DELETE CARDS

// SORT & SEARCH BOOKS
const sortBooksForm = document.querySelector("#books form");
const searchBooksForm = document.querySelectorAll("#books form")[1];
sortBooksForm.addEventListener("submit", (e) => {
    e.preventDefault();
    const sortBy = document.querySelector("#sortBooksBy").value;
    const data = getData();
    data.books.sort((a, b) => {
        if (sortBy === "countOnLibrary") {
            return a.countOnLibrary - b.countOnLibrary;
        }
        return a[sortBy].toString().localeCompare(b[sortBy].toString());
    });
    setData(data);
    location.reload();
});

searchBooksForm.addEventListener("submit", (e) => {
    e.preventDefault();
    const query = document.querySelector("#searchBooks").value.toLowerCase();
    const data = getData();
    const filteredBooks = data.books.filter(book =>
        book.name.toLowerCase().includes(query) ||
        book.author.toLowerCase().includes(query) ||
        book.publisher.toLowerCase().includes(query)
    );
    renderBooks(filteredBooks);
});

function renderBooks(books) {
    const booksTable = document.querySelector("#books tbody");
    booksTable.innerHTML = "";
    books.forEach((book) => {
        const row = document.createElement("tr");
        row.innerHTML = `
            <td>${book.id}</td>
            <td>${book.name}</td>
            <td>${book.author}</td>
            <td>${book.year}</td>
            <td>${book.publisher}</td>
            <td>${book.countOfPages}</td>
            <td>${book.countOnLibrary}</td>
            <td><div class="editBtn"><img src="img/edit.png"></div></td>
            <td><div class="deleteBtn"><img src="img/delete.png"></div></td>
        `;
        booksTable.appendChild(row);
    });
    document.querySelectorAll(".editBtn, .deleteBtn").forEach(el => el.replaceEventListeners);
    openModals();
}
// SORT & SEARCH BOOKS

// SORT & SEARCH VISITORS
const sortVisitorsForm = document.querySelector("#visitors form");
const searchVisitorsForm = document.querySelectorAll("#visitors form")[1];

sortVisitorsForm.addEventListener("submit", (e) => {
    e.preventDefault();
    const sortBy = document.querySelector("#sortVisitorsBy").value;
    const data = getData();
    data.visitors.sort((a, b) => {
        if (sortBy === "id") {
            return a.id - b.id;
        }
        return a.name.localeCompare(b.name);
    });
    setData(data);
    renderVisitors(data.visitors);
});

searchVisitorsForm.addEventListener("submit", (e) => {
    e.preventDefault();
    const query = document.querySelector("#searchVisitors").value.toLowerCase().trim();
    if (!query) return renderVisitors(getData().visitors);
    const data = getData();
    const filteredVisitors = data.visitors.filter(visitor =>
        visitor.name.toLowerCase().includes(query) ||
        visitor.phone.toString().includes(query)
    );
    renderVisitors(filteredVisitors);
});

function renderVisitors(visitors) {
    const visitorsTable = document.querySelector("#visitors tbody");
    visitorsTable.innerHTML = "";
    visitors.forEach((visitor) => {
        const row = document.createElement("tr");
        row.innerHTML = `
            <td>${visitor.id}</td>
            <td>${visitor.name}</td>
            <td>${visitor.phone}</td>
            <td><div class="editBtn"><img src="img/edit.png"></div></td>
        `;
        visitorsTable.appendChild(row);
    });
    document.querySelectorAll(".editBtn, .deleteBtn").forEach(el => el.replaceEventListeners);
    openModals();
}

function renderCards(cards) {
    const cardsTable = document.querySelector("#cards tbody");
    cardsTable.innerHTML = "";
    cards.forEach((card) => {
        const row = document.createElement("tr");
        row.innerHTML = `
            <td>${card.id}</td>
            <td>${card.visitorId}</td>
            <td>${card.bookId}</td>
            <td>${card.issueDate}</td>
            <td>${card.returnDate}</td>
            <td><button>Take back</button></td>
        `;
        cardsTable.appendChild(row);
    });
    document.querySelectorAll(".editBtn, .deleteBtn").forEach(el => el.replaceEventListeners);
    openModals();
}
// SORT & SEARCH VISITORS

// FORM CLEANUP
document.querySelectorAll("form").forEach(form => {
    form.addEventListener("submit", () => {
        form.reset();
    });
});
const allForms = document.querySelectorAll("form");
modalCloseBtns.forEach((modalCloseBtn) => {
    modalCloseBtn.addEventListener("click", () => {
        allForms.forEach(form => {
            form.reset();
        });
    });
});
// FORM CLEANUP