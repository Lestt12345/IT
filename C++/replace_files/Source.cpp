#include <iostream>
#include <io.h>
#include <direct.h>
#include <cstdlib>
#include <string>
#include <thread>
#include <chrono>
#include <Windows.h>
using namespace std;

int current_process = 0;
int error_file_count = 0;
bool in_process = true;

bool copy_file(const string& source, const string& destination) {
    string command = "copy \"" + source + "\" \"" + destination + "\"";
    int result = system(command.c_str());
    return result == 0;
}

int files_count(const string& source) {
    struct _finddata_t fileinfo;
    intptr_t handle;
    string pattern = source + "\\*";
    int f_count = 0;
    handle = _findfirst(pattern.c_str(), &fileinfo);
    if (handle != -1) {
        do {
            if (string(fileinfo.name) != "." && string(fileinfo.name) != "..") {
                f_count++;
            }
        } while (_findnext(handle, &fileinfo) == 0);
        _findclose(handle);
    }
    return f_count;
}

void files_names(const string& source, struct _finddata_t* files, const int f_count) {
    struct _finddata_t fileinfo;
    intptr_t handle;
    string pattern = source + "\\*";
    int i = 0;
    handle = _findfirst(pattern.c_str(), &fileinfo);
    if (handle != -1) {
        do {
            if (string(fileinfo.name) != "." && string(fileinfo.name) != ".." && i < f_count) {
                files[i] = fileinfo;
                i++;
            }
        } while (_findnext(handle, &fileinfo) == 0 && i < f_count);
        _findclose(handle);
    }
}

void copy_folder(const string& source, const string& destination, int& current_process, int& error_file_count, bool& in_process) {
    Sleep(100);
    int f_count = files_count(source);
    if (f_count == 0) {
        return;
    }
    else {
        struct _finddata_t* files = new _finddata_t[f_count];
        files_names(source, files, f_count);
        for (int i = 0; i < f_count; i++) {
            if (!copy_file(source + "\\" + files[i].name, destination + "\\" + files[i].name)) {
                error_file_count++;
            }
            current_process = (i + 1) * 100 / f_count;
        }
        delete[] files;
    }
    in_process = false;
}

void show_progress() {
    while (in_process) {
        cout << "Complete for " << current_process << "%...\n";
        Sleep(500);
    }
    cout << "Done\nErrors count is " << error_file_count << endl;
}

int main() {
    string source_folder;
    string destination_folder;
    cout << "Source folder: ";
    cin >> source_folder;
    cout << "Destination folder: ";
    cin >> destination_folder;
    thread progress_thread(show_progress);
    copy_folder(source_folder, destination_folder, current_process, error_file_count, in_process);
    in_process = false;
    progress_thread.join();
}