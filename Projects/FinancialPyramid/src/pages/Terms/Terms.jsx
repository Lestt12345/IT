import NavlinkStruct from "../../components/NavlinkStruct/NavlinkStruct"
import { useState, useEffect } from "react"
import "../../App.css"
import "./Terms.css"
import { Link } from "react-router-dom"
import useWindowWidth from "../../hooks/useWindowWidth"

const leftMenu = [
  { id: "terms", title: "Terms & Conditions", sumTitle: "Eligibility Requirements for Promotions" },
  { id: "offering", title: "Offering Circular", sumTitle: "Offering Circular SEC Links" },
  { id: "subscription", title: "Subscription Agreement", sumTitle: "Subscription Agreement" }
];

function Terms() {
  const [activeMenu, setActiveMenu] = useState("terms");
  const [openDoc, setOpenDoc] = useState(null);

  // здесь храним документы по категориям
  const [documents, setDocuments] = useState({
    terms: [],
    offering: [],
    subscription: []
  });

  // ---- USE EFFECT: наполняем массивы ----
  useEffect(() => {
    const loadDocs = () => {
      const generatedDocs = {
        terms: [
          {
            title: "August 2025 1% Flywheel Bonus Promo Terms and Conditions",
            content: "This Limited Time Offer is applicable to Groundfloor investors who transfer total funds equal to or exceeding the Qualifying Amount and invest those funds into the Flywheel Portfolio during the Promotional Period. All transfers, commitments, and investments must be made in a Qualifying Amount in a single, new Qualifying Account by an individual or business entity that does not already have a Groundfloor Account. Amounts transferred, committed, or invested cannot be aggregated to reach a Qualifying Amount across multiple Qualifying Accounts. The definition of a Qualifying Account is subject to change at the sole discretion of Groundfloor. Investments must be made into qualifying products of individual LROs, and the Flywheel Portfolio. Groundfloor IRA accounts are not Qualifying Accounts and are ineligible for this promotion. The Promotional Period shall begin on August 1, 2025 and end on August 12, 2025 at 11:59 PM Eastern Time.The “Promotional Period” denotes the duration within which the Qualifying Amount must be invested into the Qualifying Account. The “Qualification Period” refers to the duration during which the promotional Qualifying Amount must remain invested in the Qualifying Account to be eligible for the Investment Bonus. The Qualifying Amount shall be at least $10,000, with the 1% bonus credit being eligible for every $10,000 invested. Any transfers out during the Qualification Period and investment cancellations during the Qualification Period shall be netted against otherwise qualifying transfers, commitments, and investments in calculating eligibility. Any tabulation, report, or indication of Qualifying Amounts and bonuses earned under this promotion that is provided to you via our website, automated email, management personnel, or customer service representatives are not conclusive and are subject to revision or correction at any time in the exclusive discretion of Groundfloor. An Investment Bonus of 1% (one percent) shall be credited to the Qualifying Account in the form of restricted credits for the Qualifying Amount meeting all of the Eligibility Requirements in Investment Bonuses in aggregate per user across all Qualifying Accounts. The Investment Bonus will be added to your Groundfloor account no later than September 30, 2025. Restricted credits earned can be used towards the purchase of any Qualifying Investment. The restricted credits cannot be withdrawn as cash. If the restricted credit is not used within one year of issuance, it will expire and be removed from your Groundfloor account. Participation in this program may result in the receipt of taxable income, and we may be required to send users and file with the IRS, a Form 1099-MISC. Users are responsible for any tax liability, including disclosure requirements, related to participating in the promotion. Please consult a tax advisor if you have any questions about your personal tax situation. This Limited Time Offer is subject to change and may be canceled at any time without notice. In cases where we have a reasonable belief of fraud, we reserve the right to rescind any restricted credits that may have been given, at any time. This Limited Time Offer cannot be combined with any other Groundfloor promotion."
          },
          {
            title: "Flywheel Portfolio Promotion Terms and Conditions",
            content: "This Limited Time Offer is applicable to Groundfloor investors who meet all of the following requirement: Invest into the Flywheel during the promotional period and the investment settles and is not canceled. All investments must be made and confirmed during the timeframe of the promotional period. All investments must be made in a Qualifying Amount by an individual or business entity. Amounts invested cannot be aggregated to reach a Qualifying Amount across multiple Qualifying Accounts. The definition of a Qualifying Account is subject to change at the sole discretion of Groundfloor. Groundfloor IRA accounts are Qualifying Accounts and are eligible for this promotion. All promo credits that apply to a purchase of the Flywheel will be made into a Qualified Taxable Account. The Flywheel Investment period shall begin on October 3, 2024 at 12:00 AM Eastern Time and end on October 17, 2024 at 11:59 PM Eastern Time. The Promotional Period shall begin on October 3, 2024 and end on October 17, 2024 at 11:59 PM Eastern Time. The Qualification Period shall begin simultaneously with the Flywheel Investment Period and shall end on October 17, 2024, at 11:59 PM Eastern Time, unless extended at the sole option of Groundfloor. The “Promotional Period” denotes the duration within which the Qualifying Amount must be invested into the Qualifying Account. The “Qualification Period” refers to the duration during which the promotional Qualifying Amount must remain invested in the Qualifying Account to be eligible for the Investment Bonus. The Qualifying Amount shall be at least $10,000 and no more than $500,000 (five hundred thousand dollars), with the $200 bonus being eligible for every $10,000 invested. Any transfers out during the Qualification Period and investment cancellations during the Qualification Period shall be netted against otherwise qualifying transfers, commitments, and investments in calculating eligibility. Any tabulation, report, or indication of Qualifying Amounts and bonuses earned under this promotion that is provided to you via our website, automated email, management personnel, or customer service representatives are not conclusive and are subject to revision or correction at any time in the exclusive discretion of Groundfloor. Any total investment amount above the maximum qualifying amount of $500,000 will not be eligible for this promotion. An Investment Bonus of $200 for every $10,000 invested shall be credited to the Qualifying Account in the form of restricted credits for the Qualifying Amount meeting all of the Eligibility Requirements up to a maximum of $10,000 (ten thousand dollars) in Investment Bonuses in aggregate per user across all Qualifying Accounts. Please note that earnings are calculated based on the specific investment amount. For every $10,000 invested, you may earn $200. However, returns do not scale linearly; partial investments may not yield proportional bonus credit. The Investment Bonus will be added to your Groundfloor account no later than February 21, 2025. Restricted credits earned can be used towards the purchase of any Qualifying Investment. The restricted credits cannot be withdrawn as cash. If the restricted credit is not used within one year of issuance, it will expire and be removed from your Groundfloor account. Participation in this program may result in the receipt of taxable income, and we may be required to send users and file with the IRS, a Form 1099-MISC. Users are responsible for any tax liability, including disclosure requirements, related to participating in the promotion. Please consult a tax advisor if you have any questions about your personal tax situation. This Limited Time Offer is subject to change and may be canceled at any time without notice. In cases where we have a reasonable belief of fraud, we reserve the right to rescind any restricted credits that may have been given, at any time. This Limited Time Offer cannot be combined with any other Groundfloor promotion."
          }
        ],
        offering: [],
        subscription: []
      };

      setDocuments(generatedDocs);
    };

    loadDocs();
  }, []);

  return (
    <NavlinkStruct back_text="Rules" text1="Terms &" text2="Condition">
      <div className="container_ pt-10">
        <h1 className="text-4xl font-bold">GFL Holdings Legal Essentials</h1>
        <h4 className="text-xl font-bold pt-5">Terms, Offers & Agreements</h4>
        <p className="text-lg pt-8">We’re thrilled to have you here! Below, you’ll find important information about our legal agreements and policies for our products. If you have any questions or concerns, our support team is here to help.</p>
        <div className={`flex gap-10 py-10 ${useWindowWidth() < 992 ? "flex-col" : ""}`}>

          {/* LEFT MENU */}
          <div className={`flex gap-4 ${useWindowWidth() < 992 ? (useWindowWidth() < 768 ? "w-full justify-center items-center flex-col" : "w-full justify-around items-center flex-row") : "flex-col min-w-60"}`}>
            {leftMenu.map(item => (
              <button
                key={item.id}
                onClick={() => {
                  setActiveMenu(item.id);
                  setOpenDoc(null); // закрыть открытый документ при смене меню
                }}
                className={`flex justify-center h-12 items-center rounded-full border ${useWindowWidth() < 992 ? (useWindowWidth() < 768 ? "w-72" : "text-md min-w-48") : "text-lg"} font-medium transition px-2 ${
                  activeMenu === item.id
                    ? "bg-white text-black border-black"
                    : "bg-black text-white"
                }`}
              >
                {item.title}
              </button>
            ))}
          </div>

          {/* RIGHT MENU */}
          <div className="flex-1">
            <h2 className="text-2xl font-semibold mb-6">
              {leftMenu.find(item => item.id === activeMenu).sumTitle}
            </h2>

            <div className="flex flex-col">
              {documents[activeMenu].map((doc, index) => (
                <div key={index} className="border-b py-4">
                  <button
                    className="flex justify-between items-center w-full text-left"
                    onClick={() =>
                      setOpenDoc(openDoc === index ? null : index)
                    }
                  >
                    <span className="flex items-center gap-2 text-lg">
                      <span
                        className={`transition-transform ${
                          openDoc === index ? "rotate-90" : "rotate-0"
                        }`}
                      >
                        ▶
                      </span>
                      {doc.title}
                    </span>
                  </button>

                  {openDoc === index && (
                    <div className="mt-3 text-gray-600 text-sm pl-8">
                      {doc.content}
                    </div>
                  )}
                </div>
              ))}
            </div>

          </div>
        </div>
      </div>
    </NavlinkStruct>
  );
}

export default Terms;
