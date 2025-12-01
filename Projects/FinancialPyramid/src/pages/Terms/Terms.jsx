import NavlinkStruct from "../../components/NavlinkStruct/NavlinkStruct"
import { useState, useEffect } from "react"
import "../../App.css"
import "./Terms.css"
import { Link } from "react-router-dom"
import useWindowWidth from "../../hooks/useWindowWidth"

const leftMenu = [
  { id: "terms", title: "Terms & Conditions", subTitle: "Eligibility Requirements for Promotions" },
  { id: "offering", title: "Privacy Policy", subTitle: "Offering Circular SEC Links" },
  { id: "subscription", title: "Terms Of Service", subTitle: "Subscription Agreement" }
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
            title: "August 2025 4% Bonus Promo Terms and Conditions",
            content: "This Limited Time Offer is applicable to GFL Holdings investors who transfer total funds equal to or exceeding the Qualifying Amount and invest those funds into the GFL Holdings Investment Portfolio during the Promotional Period.\n\nAll transfers, commitments, and investments must be made in a Qualifying Amount in a single, new Qualifying Account by an individual or business entity that does not already have a GFL Holdings Account. Amounts transferred, committed, or invested cannot be aggregated to reach a Qualifying Amount across multiple Qualifying Accounts. The definition of a Qualifying Account is subject to change at the sole discretion of GFL Holdings. Investments must be made into qualifying products offered within the GFL Holdings platform, including the GFL Holdings Investment Portfolio. Retirement-type accounts or equivalent structures are not Qualifying Accounts and are ineligible for this promotion.\n\nThe Promotional Period shall begin on August 1, 2025 and end on August 12, 2025 at 11:59 PM Eastern Time. The “Promotional Period” denotes the duration within which the Qualifying Amount must be invested into the Qualifying Account. The “Qualification Period” refers to the duration during which the promotional Qualifying Amount must remain invested in the Qualifying Account to be eligible for the Investment Bonus. The Qualifying Amount shall be at least $10,000, with the 4% bonus credit being eligible for every $10,000 invested. Any transfers out during the Qualification Period and investment cancellations during the Qualification Period shall be netted against otherwise qualifying transfers, commitments, and investments in calculating eligibility.\n\nAny tabulation, report, or indication of Qualifying Amounts and bonuses earned under this promotion that is provided to you via our website, automated email, management personnel, or customer service representatives is not conclusive and is subject to revision or correction at any time in the exclusive discretion of GFL Holdings.\n\nAn Investment Bonus of 4% (four percent) shall be credited to the Qualifying Account in the form of restricted credits for the Qualifying Amount meeting all of the Eligibility Requirements. The Investment Bonus will be added to your GFL Holdings account no later than September 30, 2025. Restricted credits earned can be used toward the purchase of any Qualifying Investment. The restricted credits cannot be withdrawn as cash. If the restricted credit is not used within one year of issuance, it will expire and be removed from your GFL Holdings account.\n\nParticipation in this program may require the issuance of documentation or disclosures in accordance with applicable regulations. Users are responsible for any obligations, including reporting requirements, related to participating in the promotion. This Limited Time Offer is subject to change and may be canceled at any time without notice. In cases where we have a reasonable belief of fraud, we reserve the right to rescind any restricted credits that may have been given, at any time. This Limited Time Offer cannot be combined with any other GFL Holdings promotion."
          },
          {
            title: "Portfolio Promotion Terms and Conditions",
            content: "This Limited Time Offer is applicable to GFL Holdings investors who meet all of the following requirements: Invest into the GFL Holdings Investment Portfolio during the Promotional Period and the investment settles and is not canceled.\n\nAll investments must be made and confirmed during the timeframe of the Promotional Period. All investments must be made in a Qualifying Amount by an individual or business entity. Amounts invested cannot be aggregated to reach a Qualifying Amount across multiple Qualifying Accounts. The definition of a Qualifying Account is subject to change at the sole discretion of GFL Holdings. GFL Holdings maintains four investment account types, each of which may qualify for this promotion depending on the company’s discretion.\n\nAll promo credits that apply to a purchase of the GFL Holdings Investment Portfolio will be made into a Qualified Account. The Investment Period for each annual cycle shall begin on March 17 at 12:00 AM GMT and end on June 17 at 11:59 PM GMT. The Promotional Period shall begin on March 17 and end on June 17 at 11:59 PM GMT for each applicable year through December 31, 2027. The Qualification Period shall begin simultaneously with the Investment Period and shall end on June 17 at 11:59 PM GMT of the same year, unless extended at the sole option of GFL Holdings. The “Promotional Period” denotes the duration within which the Qualifying Amount must be invested into the Qualifying Account. The “Qualification Period” refers to the duration during which the promotional Qualifying Amount must remain invested in the Qualifying Account to be eligible for the Investment Bonus.\n\nThe Qualifying Amount shall be at least $10,000 and no more than $500,000 (five hundred thousand dollars), with the $200 bonus being eligible for every $10,000 invested. Any transfers out during the Qualification Period and investment cancellations during the Qualification Period shall be netted against otherwise qualifying transfers, commitments, and investments in calculating eligibility. Any tabulation, report, or indication of Qualifying Amounts and bonuses earned under this promotion that is provided to you via our website, automated email, management personnel, or customer service representatives is not conclusive and is subject to revision or correction at any time in the exclusive discretion of GFL Holdings. Any total investment amount above the maximum qualifying amount of $500,000 will not be eligible for this promotion.\n\nAn Investment Bonus of $200 for every $10,000 invested shall be credited to the Qualifying Account in the form of restricted credits for the Qualifying Amount meeting all the Eligibility Requirements up to a maximum of $10,000 (ten thousand dollars) in Investment Bonuses in aggregate per user across all Qualifying Accounts. Please note that earnings are calculated based on the specific investment amount. For every $10,000 invested, you may earn $200. However, returns do not scale linearly; partial investments may not yield proportional bonus credit. The Investment Bonus will be added to your GFL Holdings account no later than September 21 following the conclusion of each annual Promotional Period. Restricted credits earned can be used towards the purchase of any Qualifying Investment.\n\nThe restricted credits cannot be withdrawn as cash. If the restricted credit is not used within one year of issuance, it will expire and be removed from your GFL Holdings account. Participation in this program may require the issuance of documentation or reporting in accordance with applicable regulatory requirements. Users are responsible for any obligations, including disclosures, associated with participating in the promotion. Please consult a professional advisor if you have any questions about your personal compliance requirements. This Limited Time Offer is subject to change and may be canceled at any time without notice. In cases where we have a reasonable belief of fraud, we reserve the right to rescind any restricted credits that may have been given, at any time. This Limited Time Offer cannot be combined with any other GFL Holdings promotion.\n\nGFL Holdings is a United Kingdom–based company providing investment services across all CIS countries and European territories, excluding the United States, Israel, and China."
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
              {leftMenu.find(item => item.id === activeMenu).subTitle}
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
                    <div className="mt-3 text-gray-600 text-sm pl-8" style={{ whiteSpace: "pre-line" }}>
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
