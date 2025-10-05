'use client'

import './styles/Header_.css'
import { useLocation } from 'react-router-dom'  // Импортируем useLocation
import React, { useEffect } from 'react';
import { useState } from 'react'
import {
  Dialog,
  DialogPanel,
  Disclosure,
  DisclosureButton,
  DisclosurePanel,
  Popover,
  PopoverButton,
  PopoverGroup,
  PopoverPanel,
} from '@headlessui/react'
import {
  Bars3Icon,
  XMarkIcon,
  MagnifyingGlassIcon
} from '@heroicons/react/24/outline'
import { ChevronDownIcon } from '@heroicons/react/20/solid'

const products = [
  { name: 'Телефоны', href: '#' },
  { name: 'Ноутбуки', href: '#' },
  { name: 'Планшеты', href: '#' },
  { name: 'ПК', href: '#' },
  { name: 'Мониторы', href: '#' },
]

export default function Header_() {
  const [mobileMenuOpen, setMobileMenuOpen] = useState(false);
  const [isAuthenticated, setIsAuthenticated] = useState(false);
  const location = useLocation();

  useEffect(() => {
    // Проверяем статус авторизации
    const authStatus = sessionStorage.getItem('is_authenticated');
    setIsAuthenticated(authStatus === 'true');
  }, []);

  const handleLogout = () => {
    sessionStorage.removeItem('is_authenticated'); // Удаляем данные о сессии
    setIsAuthenticated(false);
  };
  return (
    <header className="bg-teal-200">
      <nav aria-label="Global" className="mx-auto flex max-w-7xl items-center justify-between p-6 lg:px-8">
        <div className="flex lg:flex-1">
        <a href="#" className="-m-1.5 p-1.5 flex items-center">
          <div className="flex items-center">
            <span className="text-teal-500 frstD text-sm font-bold">Dep</span>
            <span className="text-indigo-400 text-2xl font-bold">Dev</span>
          </div>
          <span className="text-teal-600 text-xl font-medium ml-3">Device Depot</span>
        </a>
        </div>
        <div className="flex lg:hidden">
          <button
            type="button"
            onClick={() => setMobileMenuOpen(true)}
            className="-m-2.5 inline-flex items-center justify-center rounded-md p-2.5 text-gray-700"
          >
            <span className="sr-only">Open main menu</span>
            <Bars3Icon aria-hidden="true" className="size-6" />
          </button>
        </div>
        <PopoverGroup className="hidden lg:flex items-center text-xl/6 lg:gap-x-12">
          <div className="relative">
            <input
              type="text"
              placeholder="Поиск..."
              className="w-full rounded-md bg-teal-100 bord p-1 text-gray-900 shadow-sm focus:ring-2 focus:ring-teal-500 focus:outline-none"
            />
            <button
              type="button"
              className="absolute right-2 top-2 text-teal-500 hover:text-teal-700"
            >
              <MagnifyingGlassIcon className="w-5 h-5" />
            </button>
          </div>
          <Popover className="relative">
            <PopoverButton className="group flex gap-x-1 font-semibold text-gray-900">
              Категории
              <ChevronDownIcon aria-hidden="true" className="size-7 flex-none group-data-open:rotate-180" />
            </PopoverButton>
            <PopoverPanel
              transition
              className="absolute top-full left-5 z-10 mt-3 overflow-hidden rounded-3xl bg-white ring-1 shadow-lg ring-gray-900/5 transition data-closed:translate-y-1 data-closed:opacity-0 data-enter:duration-200 data-enter:ease-out data-leave:duration-150 data-leave:ease-in"
            >
              <div className="p-4">
                {products.map((item) => (
                  <div
                    key={item.name}
                    className="group relative flex items-center gap-x-6 rounded-lg p-4 text-base/6 hover:bg-gray-50"
                  >
                    <div className="flex-auto">
                      <a href={item.href} className="block font-semibold text-gray-900">
                      {item.name}
                        <span className="absolute inset-0" />
                      </a>
                    </div>
                  </div>
                ))}
              </div>
            </PopoverPanel>
          </Popover>
          <a href="#" className="font-semibold text-gray-900">
            О нас
          </a>
        </PopoverGroup>
        <div className="hidden lg:flex lg:flex-1 lg:justify-end items-center gap-4">
        {isAuthenticated ? (
          <div className="flex items-center gap-2">
            <span className="text-xl font-semibold text-gray-900">
              {userName}
            </span>
            <button
              onClick={handleLogout}
              className="flex items-center justify-center text-red-600 hover:text-red-800"
            >
              <svg
                xmlns="http://www.w3.org/2000/svg"
                className="h-6 w-6"
                fill="none"
                viewBox="0 0 24 24"
                stroke="currentColor"
                strokeWidth={2}
              >
                <path
                  strokeLinecap="round"
                  strokeLinejoin="round"
                  d="M17 16l4-4m0 0l-4-4m4 4H7m6 4v1m0-11V4m0 4v4"
                />
              </svg>
            </button>
          </div>
        ) : (
          <a href="/auth"
            className="text-xl font-semibold text-gray-900 cursor-pointer"
          >
            Авторизироваться <span aria-hidden="true">&rarr;</span>
          </a>
        )}
      </div>
      </nav>
      <Dialog open={mobileMenuOpen} onClose={setMobileMenuOpen} className="lg:hidden">
      <div className="fixed inset-0 z-10" />
        <DialogPanel className="fixed inset-y-0 right-0 z-10 w-full overflow-y-auto bg-white px-6 py-6 sm:max-w-sm sm:ring-1 sm:ring-gray-900/10">
          <div className="flex items-center justify-between">
            <a href="#" className="-m-1.5 p-1.5">
              <div className="flex items-center">
                <span className="text-teal-500 frstD text-sm font-bold">Dep</span>
                <span className="text-indigo-400 text-2xl font-bold">Dev</span>
              </div>
            </a>
            <button
              type="button"
              onClick={() => setMobileMenuOpen(false)}
              className="-m-2.5 rounded-md p-2.5 text-gray-700"
            >
              <span className="sr-only">Close menu</span>
              <XMarkIcon aria-hidden="true" className="size-6" />
            </button>
          </div>
          <div className="mt-6 flow-root">
            <div className="-my-6 divide-y divide-gray-500/10">
              <div className="space-y-2 py-6 text-xl/7">
                <Disclosure as="div" className="-mx-3">
                <div className="relative flex-1 mx-3 mb-3 items-center">
                  <input
                    type="text"
                    placeholder="Поиск..."
                    className="w-full rounded-md bord p-2 text-gray-900 shadow-sm focus:ring-2 focus:ring-teal-500 focus:outline-none"
                  />
                  <button
                    type="button"
                    className="absolute right-2 top-3 text-teal-500 hover:text-teal-700"
                  >
                    <MagnifyingGlassIcon className="w-5 h-5" />
                  </button>
                </div>
                  <DisclosureButton className="w-full rounded-lg group flex rounded-lg px-3 py-2 pr-3.5 pl-3 font-semibold text-gray-900 hover:bg-gray-50">
                    Категории
                    <ChevronDownIcon aria-hidden="true" className="ml-1 size-8 flex-none group-data-open:rotate-180" />
                  </DisclosureButton>
                  <DisclosurePanel className="mt-2 space-y-2">
                    {[...products].map((item) => (
                      <DisclosureButton
                        key={item.name}
                        as="a"
                        href={item.href}
                        className="block rounded-lg py-2 pr-3 pl-7 text-lg/7 font-semibold text-gray-900 hover:bg-gray-50"
                      >
                        {item.name}
                      </DisclosureButton>
                    ))}
                  </DisclosurePanel>
                </Disclosure>
                <a
                  href="#"
                  className="text-xl/7 -mx-3 block rounded-lg px-3 py-2 font-semibold text-gray-900 hover:bg-gray-50"
                >
                  О нас
                </a>
              </div>
              <div className="py-6">
                <a
                  href="#"
                  className="-mx-3 block rounded-lg px-3 py-2.5 text-xl/7 font-semibold text-gray-900 hover:bg-gray-50"
                >
                  Авторизироваться
                </a>
              </div>
            </div>
          </div>
        </DialogPanel>
      </Dialog>
    </header>
  )
}